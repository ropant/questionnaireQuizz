using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    public partial class questions : Form
    {
        private string texteRecu;  // nom du thème

        public questions(string contenu)
        {
            InitializeComponent();
            this.texteRecu = contenu;

            lbl_theme.Text = "Thème sélectionné : " + texteRecu;
            ChargerQuestions(texteRecu);
        }


        private void ChargerQuestions(string nomTheme)
        {
            try
            {

                MySqlConnection conn = Program.connection;



                string query = @"
                    SELECT q.libelle AS 'Questions'
                    FROM question q
                    JOIN questionnaire qr ON q.id_questionnaire = qr.id_questionnaire
                    JOIN theme t ON qr.id_theme = t.id_theme
                    WHERE t.nom = @nomTheme
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // On passe le paramètre @nomTheme à la requête
                    cmd.Parameters.AddWithValue("@nomTheme", nomTheme);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Affichage dans dataGridViewQuestions
                        datagrd_questions.DataSource = dt;
                        datagrd_questions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des questions : " + ex.Message);
            }
        }

        private void btn_backTheme_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
