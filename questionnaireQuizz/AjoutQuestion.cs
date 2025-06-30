using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    public partial class AjoutQuestion : Form
    {
        MySqlConnection conn = Program.connection;
        public AjoutQuestion()
        {
            InitializeComponent();
            this.Load += AjoutQuestion_Load;
        }

        private void AjoutQuestion_Load(object sender, EventArgs e)
        {
            ChargerQuestionnaires();
        }

        private void bnt_valider_Click(object sender, EventArgs e)
        {
            // 1) Lecture des champs
            string libelle = rtb_libelleQuestion.Text.Trim();
            string rep1 = txt_question1.Text.Trim();
            string rep2 = txt_question2.Text.Trim();
            string rep3 = txt_question3.Text.Trim();
            string bonneReponse = txt_bonneReponse.Text.Trim();

            // 2) Vérifier qu'un questionnaire est sélectionné
            if (cB_questionnaire.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.",
                                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idQuestionnaire = Convert.ToInt32(cB_questionnaire.SelectedValue);

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // 3) Requête INSERT incluant id_questionnaire
                string query = @"
                    INSERT INTO `question`
                      (`libelle`, `rep1`, `rep2`, `rep3`, `bonne_reponse`, `id_questionnaire`)
                    VALUES
                      (@libelle, @rep1, @rep2, @rep3, @bonneReponse, @idQuestionnaire);
                ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    cmd.Parameters.AddWithValue("@rep1", rep1);
                    cmd.Parameters.AddWithValue("@rep2", rep2);
                    cmd.Parameters.AddWithValue("@rep3", rep3);
                    cmd.Parameters.AddWithValue("@bonneReponse", bonneReponse);
                    cmd.Parameters.AddWithValue("@idQuestionnaire", idQuestionnaire);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0
                        ? "La question a bien été ajoutée !"
                        : "L'insertion a échoué.",
                        "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'insertion : {ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void ChargerQuestionnaires()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string requete = @"
                    SELECT id_questionnaire, nom_questionnaire
                    FROM questionnaire
                    ORDER BY nom_questionnaire;
                ";

                using (var cmd = new MySqlCommand(requete, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aucun questionnaire disponible.",
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cB_questionnaire.DataSource = dt;
                    cB_questionnaire.DisplayMember = "nom_questionnaire";
                    cB_questionnaire.ValueMember = "id_questionnaire";
                    cB_questionnaire.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des questionnaires :\n{ex.Message}",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
