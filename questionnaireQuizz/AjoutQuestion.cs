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
           
        }
        private void AjoutQuestion_Load(object sender, EventArgs e)
        {
            ChargerQuestionnaires();
        }



        private void bnt_valider_Click(object sender, EventArgs e)
        {
            string libelle = rtb_libelleQuestion.Text.ToString();
            string rep1 = txt_question1.Text.Trim();
            string rep2 = txt_question2.Text.Trim();
            string rep3 = txt_question3.Text.Trim();
            string reponseBonne = txt_bonneReponse.Text.Trim();


            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string query = @"
                    INSERT INTO question (libelle, id_type, rep1, rep2, rep3, bonne_reponse)
                    VALUES (@libelle, 1, @rep1, @rep2, @rep3, @reponseBonne)
                ";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Associer chaque paramètre à la valeur saisie
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    cmd.Parameters.AddWithValue("@rep1", rep1);
                    cmd.Parameters.AddWithValue("@rep2", rep2);
                    cmd.Parameters.AddWithValue("@rep3", rep3);
                    cmd.Parameters.AddWithValue("@reponseBonne", reponseBonne);

                    // Exécuter la requête
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("La question a bien été ajoutée !");
                    }
                    else
                    {
                        MessageBox.Show("L'insertion a échoué.");
                    }

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);

            }
          





        }
        private void ChargerQuestionnaires()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Requête pour récupérer l'id et le nom de tous les questionnaires
                string requete = "SELECT id_questionnaire, nom_questionnaire FROM questionnaire";

                using (MySqlCommand cmd = new MySqlCommand(requete, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Associer le DataTable à la ComboBox
                    cB_questionnaire.DataSource = dt;
                    cB_questionnaire.DisplayMember = "nom_questionnaire";   // Texte affiché
                    cB_questionnaire.ValueMember = "id_questionnaire";      // Valeur associée
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des questionnaires : " + ex.Message);
            }
        }
    }
}
