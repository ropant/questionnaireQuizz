using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = Program.connection;
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ChargerQuestionnairesAnciens();
        }
        private void ChargerQuestionnairesAnciens()
        {
            try
            {
                //requête pour aller chercher les questionnaire qui ont plus de 5 ans 
                string sql = @"
                    SELECT  nom_questionnaire, date_creation
                    FROM questionnaire
                    WHERE date_creation < DATE_SUB(NOW(), INTERVAL 5 YEAR)
                    ORDER BY date_creation";

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
                MessageBox.Show("Erreur lors du chargement des questionnaires : " + ex.Message);
            }
            
       
        }
    }
}




    

   
       
