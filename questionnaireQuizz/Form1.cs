using MySql.Data.MySqlClient; // pour les objets MySQL
using System.Data;            // pour DataTable
using Microsoft.VisualBasic;

namespace questionnaireQuizz
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = Program.connection;//appel de la methode pour me connecter a la base de donn�e 
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView_questions.Hide();

        }

        private void btn_afficherThemes_Click(object sender, EventArgs e)
        {
            dataGridView_questions.Hide();

            //requ�te sql
            string query = "SELECT nom AS 'Th�mes' FROM theme";

            try
            {

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
                MessageBox.Show("Erreur lors de l'affichage des th�mes : " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string content = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            questions frmQuestions = new questions(content);
            this.Hide();
            frmQuestions.ShowDialog();



        }

        private void btn_afficherQuestion_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM question";
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
            //  Afficher une bo�te de dialogue pour saisir le nom du questionnaire
            string nomQuestionnaire = Interaction.InputBox(
                "Entrez le nom du nouveau questionnaire :",
                "Cr�er un questionnaire",
                "Questionnaire par d�faut"
            );

            // Si l'utilisateur clique sur "Annuler" ou laisse vide, on arr�te
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

                MessageBox.Show("Le questionnaire a �t� cr�� avec succ�s !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la cr�ation du questionnaire : " + ex.Message);
            }



        }

        private void toolStrip_AddTOQuestionnaire_Click(object sender, EventArgs e)
        {
            AjoutQuestion ajoutQuestion = new AjoutQuestion();
            ajoutQuestion.ShowDialog();
            this.Hide();

        }

        private void cr�erUnQuestionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createQuestionnaire createQuestionnaire = new createQuestionnaire();
            createQuestionnaire.ShowDialog();
            this.Hide();
        }

        private void modifierUneQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  questionQuestionnaire questionQuestionnaire = new questionQuestionnaire();
           // questionQuestionnaire.ShowDialog();
           // this.Hide();   
        }
    }
}
