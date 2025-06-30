using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;

namespace questionnaireQuizz
{
    public partial class connexion : Form
    {
        MySqlConnection conn = Program.connection;

        public connexion()
        {
            InitializeComponent();

            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // --- (4) Lien “créer mon compte” (txt_creerCompte) ---
            txt_creerCompte.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            txt_creerCompte.ForeColor = Color.FromArgb(0, 120, 215);
            txt_creerCompte.AutoSize = true;
          
        
            //bouton style
                    button1.Text = "Connexion";
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button1.BackColor = Color.FromArgb(0, 120, 215);    // bleu légèrement foncé (#0078D7)
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 180);   // bleu survol
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 170);     // bleu “clic”
            button1.Size = new Size(120, 30);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txt_motDePasse.Text.Trim();
            string identifiant = txt_id.Text.Trim();
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");

            string query = @"
                SELECT id_utilisateur, mot_passe_utilisateur, Activation
                FROM utilisateur
                WHERE nom_utilisateur = @identifiant;
                
            ";

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                int userId = 0;


                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@identifiant", identifiant);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read() ||
                            !BCrypt.Net.BCrypt.Verify(password, reader.GetString("mot_passe_utilisateur")))
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrect !");
                            return;
                        }

                        if (reader.GetInt32("Activation") == 1)
                        {
                            MessageBox.Show("Votre accès a été interdit !");
                            return;
                        }
                        userId = reader.GetInt32("id_utilisateur");
                    }
                   
                }
                String updateTemps = @"UPDATE utilisateur SET nbr_connexion = nbr_connexion + 1, last_connection = NOW() WHERE id_utilisateur = @userId";

                using (var cmdIns = new MySqlCommand(updateTemps, conn))
                {
                    cmdIns.Parameters.AddWithValue("@userId", userId);
                    cmdIns.ExecuteNonQuery();

                };

                String insertTemps = @" INSERT into temps_connexion(id_utilisateur,time_connexion) Values (@userId, NOW())";

                using (var cmdIns = new MySqlCommand(insertTemps, conn))
                {
                    cmdIns.Parameters.AddWithValue("@userId", userId);
                    cmdIns.ExecuteNonQuery();
                }


                // Si on arrive ici, tout est OK :
                this.Hide();
                var mainForm = new Form1(userId);
                mainForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
            }
            finally
            {
                // <-- Très important : on ferme la connexion dès qu'on a fini
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        private void txt_creerCompte_Click(object sender, EventArgs e)
        {
            using (var register = new register())
                register.ShowDialog();
            this.Close();
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
