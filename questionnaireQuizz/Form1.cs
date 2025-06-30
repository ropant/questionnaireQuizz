using MySql.Data.MySqlClient; 
using System.Data;            
using Microsoft.VisualBasic;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;

namespace questionnaireQuizz
{

    public partial class Form1 : Form
    {
        MySqlConnection conn = Program.connection;//connexion bdd
        private int userId;
        public Form1(int id)
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView_questions.Hide();
            this.BackColor = Color.FromArgb(245, 245, 250);
            userId = id;
            //modifications
            btn_getID.Hide();
            txt_id.Hide();
            txt_nom.Hide();
            label1.Hide();
            label2.Hide();
            txt_nbrConnexion.Hide();
            txt_derniereConnection.Hide();
            afficherLesQuestionnairesToolStripMenuItem.Visible = false;
            afficherLesQuestionsToolStripMenuItem.Visible = false;
            btn_deconnecter.Hide();

            // — Styliser le MenuStrip et ses items —
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.FromArgb(50, 50, 50);
                item.BackColor = Color.White;
                item.Margin = new Padding(2, 0, 2, 0);
                // Survol
                item.MouseEnter += (s, e) => { item.BackColor = Color.FromArgb(230, 230, 230); };
                item.MouseLeave += (s, e) => { item.BackColor = Color.White; };
            }

            // — Styliser les Buttons principaux —
            foreach (var ctl in this.Controls)
                if (ctl is Button btn)
                {
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(0, 120, 215);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 180);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 170);
                    btn.Size = new Size(200, 30);
                }

            // — Styliser les DataGridView —
            Action<DataGridView> styleGrid = grid =>
            {
                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                grid.RowHeadersVisible = false;
                grid.GridColor = Color.LightGray;
                grid.BorderStyle = BorderStyle.None;
                grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                grid.DefaultCellStyle.SelectionForeColor = Color.White;
            };
            styleGrid(dataGridView1);
            styleGrid(dataGridView_questions);


        }

        private void btn_afficherThemes_Click(object sender, EventArgs e)
        {
           // dataGridView_questions.Hide();


            dataGridView_questions.Hide();
            ChargerThemesAvecNombreQuestionnaires();

        }
        private void ChargerThemesAvecNombreQuestionnaires()
        {
            try
            {
                string sql = @"
            SELECT  t.nom AS Theme, COUNT(q.id_questionnaire) AS NombreQuestionnaires
            FROM theme t
            LEFT JOIN questionnaire q ON q.id_theme = t.id_theme
            GROUP BY t.id_theme, t.nom
            ORDER BY t.nom;";

                DataTable dt = new DataTable();
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des thèmes : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void ChargerThemesSansQuestionnaire()
        {
            try
            {
                string sql = @"
            SELECT  nom AS Theme
            FROM theme
            WHERE id_theme NOT IN (SELECT id_theme FROM questionnaire)
            ORDER BY nom;";

                DataTable dt = new DataTable();
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des thèmes sans questionnaire : " + ex.Message);
            }
         
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string content = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            // 2) Au lieu de new questions(content), on lui passe aussi userId :
            questions frmQuestions = new questions(this.userId, content);

            // 3) On cache l’instance courante de Form1 avant d’ouvrir questions
            this.Hide();

            // 4) On ouvre questions en modal
            frmQuestions.ShowDialog();

            // 5) Dès que questions est fermé, l’exécution reprend ici, on ré-affiche Form1
            this.Show();



        }

        private void btn_afficherQuestion_Click(object sender, EventArgs e)
        {
            string query = "SELECT libelle,rep1,rep2,rep3,bonne_reponse,id_questionnaire FROM question";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        dataGridView_questions.DataSource = dt;
                        dataGridView_questions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView_questions.Show();
                        dataGridView1.Hide();


                    }
                }

            }
            catch
            {

            }

        }

        private void toolStrip_newQuestionnaire_Click(object sender, EventArgs e)
        {
            //  Afficher une boîte de dialogue pour saisir le nom du questionnaire
            string nomQuestionnaire = Interaction.InputBox(
                "Entrez le nom du nouveau questionnaire :",
                "Créer un questionnaire",
                "Questionnaire par défaut"
            );

            // Si l'utilisateur clique sur "Annuler" ou laisse vide, on arrête
            if (string.IsNullOrWhiteSpace(nomQuestionnaire))
            {
                return;
            }

            try
            {

                string insertQuery = "INSERT INTO questionnaire (nom_questionnaire, id_theme) VALUES (@nomQ, 4)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nomQ", nomQuestionnaire);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Le questionnaire a été créé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du questionnaire : " + ex.Message);
            }



        }

        private void toolStrip_AddTOQuestionnaire_Click(object sender, EventArgs e)
        {
            AjoutQuestion ajoutQuestion = new AjoutQuestion();
            ajoutQuestion.ShowDialog();
            this.Hide();

        }

        private void créerUnQuestionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

            //  ouvre createQuestionnaire en modal
            using (var createQuestionnaireForm = new createQuestionnaire())
            {
                createQuestionnaireForm.ShowDialog();
            }

            // 3) dès que le dialog est fermé, on ré-affiche Form1
            this.Show();
        }

        private void modifierUneQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  questionQuestionnaire questionQuestionnaire = new questionQuestionnaire();
            // questionQuestionnaire.ShowDialog();
            // this.Hide();   
        }

        private void voirLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            //  ouvre utilisateurAdmin en modal
            using (var utilisateurAdminForm = new utilisateurAdmin())
            {
                utilisateurAdminForm.ShowDialog();
            }


            this.Show();
        }

        private void afficherLesQuestionnairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string sql =
         @"SELECT t.id_theme, t.nom AS Theme,
                 qz.id_questionnaire, qz.nom_questionnaire AS Questionnaire,
                 qs.id_question, qs.libelle AS Question
          FROM theme t
          JOIN questionnaire qz ON qz.id_theme = t.id_theme
          JOIN question qs ON qs.id_questionnaire = qz.id_questionnaire
          ORDER BY t.nom, qz.nom_questionnaire, qs.id_question;";

            try
            {
                // Récupération des données
                DataTable dt = new DataTable();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var adp = new MySqlDataAdapter(cmd))
                {
                    adp.Fill(dt);
                }

                // Génération + chemin temporaire
                string pdfPath = Path.Combine(
                    Path.GetTempPath(),
                    $"Questionnaires_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

                CreateQuestionnairePdf(dt, pdfPath);

                // Ouverture avec le lecteur PDF par défaut
                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur PDF : " + ex.Message);
            }
        }


        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            string nom_utilisateur = txt_nom.Text.Trim();
            int id_utilisateur = GetUserIdByNom(nom_utilisateur);
            txt_id.Text = id_utilisateur.ToString();
        }



        private int GetUserIdByNom(string nom)
        {
            int userId = 0;

            using (MySqlCommand cmd = new MySqlCommand("rechercherID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", nom);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return userId;
        }
        private void CreateQuestionnairePdf(DataTable dt, string filePath)
        {
            var doc = new PdfDocument();
            var page = doc.AddPage();
            var gfx = XGraphics.FromPdfPage(page);

            // Styles
            var fTheme = new XFont("Arial", 16, XFontStyleEx.Bold);
            var fQuiz = new XFont("Arial", 13, XFontStyleEx.Bold);
            var fQuestion = new XFont("Arial", 11, XFontStyleEx.Regular);

            double y = 40, left = 50, line = 20, bottom = page.Height - 40;
            int curTheme = -1, curQuiz = -1;

            foreach (DataRow r in dt.Rows)
            {
                if ((int)r["id_theme"] != curTheme)
                {
                    curTheme = (int)r["id_theme"];
                    y = WriteLine(gfx, fTheme, r["Theme"].ToString(), left, y,
                                  line, ref page, ref gfx, bottom);
                    curQuiz = -1;
                }
                if ((int)r["id_questionnaire"] != curQuiz)
                {
                    curQuiz = (int)r["id_questionnaire"];
                    y = WriteLine(gfx, fQuiz, "• " + r["Questionnaire"],
                                  left + 10, y, line, ref page, ref gfx, bottom);
                }
                y = WriteLine(gfx, fQuestion, "- " + r["Question"],
                              left + 30, y, line, ref page, ref gfx, bottom);
            }

            doc.Save(filePath);
            doc.Close();
        }

        private double WriteLine(XGraphics gfx, XFont font, string text,
                                 double x, double y, double lineHeight,
                                 ref PdfPage page, ref XGraphics graphics, double bottom)
        {
            if (y > bottom)                         // saut de page
            {
                page = gfx.PdfPage.Owner.AddPage();
                graphics = XGraphics.FromPdfPage(page);
                y = 40;
            }
            graphics.DrawString(text, font, XBrushes.Black, new XPoint(x, y));
            return y + lineHeight;
        }

        private void btn_getID_Click(object sender, EventArgs e)
        {

        }
        private void createTheme_Click(object sender, EventArgs e)
        { }


        private void RafraichirGridThèmes()
        {
            try
            {
                string query = "SELECT nom AS 'Thèmes' FROM theme;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors du rafraîchissement des thèmes : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void createTheme_Click_1(object sender, EventArgs e)
        {
            // 1) Affiche une InputBox pour demander le nom du nouveau thème
            string nomTheme = Interaction.InputBox(
                "Entrez le nom du nouveau thème :",
                "Créer un thème",
                "" // Valeur par défaut vide
            );

            // Si l'utilisateur annule ou ne tape rien, on s'arrête
            if (string.IsNullOrWhiteSpace(nomTheme))
            {
                return;
            }

            try
            {
                // 2) Ouvrir la connexion si elle n'est pas déjà ouverte
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // 3) Préparer et exécuter la commande d'insertion
                string insertQuery = "INSERT INTO theme (nom) VALUES (@nomTheme);";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nomTheme", nomTheme.Trim());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Le thème \"" + nomTheme + "\" a été créé avec succès !",
                            "Succès",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // 4) On rafraîchit la grille pour afficher immédiatement le nouveau thème
                        RafraichirGridThèmes();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Échec de la création du thème.",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de la création du thème : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }


        }

        private void btn_deconnecter_Click(object sender, EventArgs e)
        {
            int userId = this.userId;

            const string updateSql = @"
        UPDATE temps_connexion
           SET time_deconnexion = NOW()
         WHERE id_temps_connexion = (
             SELECT t.id_temps_connexion
               FROM (
                   SELECT id_temps_connexion
                     FROM temps_connexion
                    WHERE id_utilisateur = @userId
                    ORDER BY time_connexion DESC
                    LIMIT 1
               ) AS t
         );
    ";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var cmd = new MySqlCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Aucune session de connexion trouvée pour cet utilisateur.",
                                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la déconnexion : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            // 5) Fermer Form1 et revenir à la fenêtre de connexion
            this.Hide();
            using (var loginForm = new connexion())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }

        private void afficherLesQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();


            using (var frm = new FrmDureeConnexion())
            {
                frm.ShowDialog();
            }


            this.Show();
        }
        private void afficherNbrConnexion(int userId)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var cmd = new MySqlCommand("procedure_nbr_connexion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // On passe le paramètre p_userId (correspond à IN p_userId INT)
                    cmd.Parameters.AddWithValue("p_userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupère les colonnes "nbr_connexion" et "last_connection"
                            int nbr = reader.IsDBNull(reader.GetOrdinal("nbr_connexion"))
                                      ? 0
                                      : reader.GetInt32("nbr_connexion");

                            // last_connection peut être NULL
                            DateTime? last = reader.IsDBNull(reader.GetOrdinal("last_connection"))
                                             ? (DateTime?)null
                                             : reader.GetDateTime("last_connection");

                            // On affecte aux Labels (ou à tout autre contrôle)
                            txt_nbrConnexion.Text = nbr.ToString();
                            txt_derniereConnection.Text = last.HasValue
                                                     ? last.Value.ToString("yyyy-MM-dd HH:mm:ss")
                                                     : "–";
                        }
                        else
                        {
                            // Aucun enregistrement retourné (ID inexistant)
                            txt_nbrConnexion.Text = "0";
                            txt_derniereConnection.Text = "–";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des stats : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_afficherQuestionnaire_Click(object sender, EventArgs e)
        {
            this.Hide();

            //  ouvre utilisateurAdmin en modal
            using (var form2 = new Form2())
            {
                form2.ShowDialog();
            }


            this.Show();
        }

        private void btn_filtre_Click(object sender, EventArgs e)
        {
            ChargerThemesSansQuestionnaire();
        }
    }
}
