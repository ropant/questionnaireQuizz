using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    public partial class createQuestionnaire : Form
    {
        // Récupération de la connexion MySQL (déjà configurée dans Program)
        MySqlConnection conn = Program.connection;

        public createQuestionnaire()
        {
            InitializeComponent();

            // Abonner l'événement Load du formulaire pour charger les thèmes
            this.Load += CreateQuestionnaire_Load;
        }

        private void CreateQuestionnaire_Load(object sender, EventArgs e)
        {
            ChargerThemes();
        }

        /// <summary>
        /// Récupère la liste des thèmes depuis la table 'theme' et les affiche dans la comboBoxTheme.
        /// </summary>
        private void ChargerThemes()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string requete = "SELECT id_theme, nom FROM theme";
                using (MySqlCommand cmd = new MySqlCommand(requete, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // On lie le DataTable à la ComboBox
                    cb_themeQuestionnaire.DataSource = dt;
                    // La propriété DisplayMember détermine ce qui s'affiche
                    cb_themeQuestionnaire.DisplayMember = "nom";
                    // La propriété ValueMember est la valeur réelle (id_theme)
                    cb_themeQuestionnaire.ValueMember = "id_theme";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des thèmes : " + ex.Message);
            }
        }

        /// <summary>
        /// Gère le clic sur le bouton Valider : insère un nouveau questionnaire dans la table.
        /// </summary>
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs
            string nomQuestionnaire = rtb_nomQuestionnaire.Text.Trim();

            // Récupération de l'id_theme sélectionné
            int themeSelectionne;
            try
            {
                themeSelectionne = Convert.ToInt32(cb_themeQuestionnaire.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un thème valide.");
                return;
            }

            // Vérification rapide si le champ nom est vide
            if (string.IsNullOrWhiteSpace(nomQuestionnaire))
            {
                MessageBox.Show("Veuillez entrer un nom de questionnaire.");
                return;
            }

            // Insertion en base de données
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string insertQuery = "INSERT INTO questionnaire (nom_questionnaire, id_theme) VALUES (@nomQ, @idTheme)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nomQ", nomQuestionnaire);
                    cmd.Parameters.AddWithValue("@idTheme", themeSelectionne);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Questionnaire créé avec succès !");
                        // Vous pouvez fermer ce formulaire ou le vider, selon votre logique
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La création du questionnaire a échoué.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du questionnaire : " + ex.Message);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs
            string nomQuestionnaire = rtb_nomQuestionnaire.Text.Trim();

            // Récupération de l'id_theme sélectionné
            int themeSelectionne;
            try
            {
                themeSelectionne = Convert.ToInt32(cb_themeQuestionnaire.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un thème valide.");
                return;
            }

            // Vérification rapide si le champ nom est vide
            if (string.IsNullOrWhiteSpace(nomQuestionnaire))
            {
                MessageBox.Show("Veuillez entrer un nom de questionnaire.");
                return;
            }

            // Insertion en base de données
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string insertQuery = "INSERT INTO questionnaire (nom_questionnaire, id_theme) VALUES (@nomQ, @idTheme)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nomQ", nomQuestionnaire);
                    cmd.Parameters.AddWithValue("@idTheme", themeSelectionne);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Questionnaire créé avec succès !");
                        this.Close(); // Ferme le formulaire après succès (optionnel)
                    }
                    else
                    {
                        MessageBox.Show("La création du questionnaire a échoué.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du questionnaire : " + ex.Message);
            }
        }
    }
}
