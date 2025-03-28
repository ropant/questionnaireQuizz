using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net; // Assurez-vous d'avoir ajouté la référence via NuGet

namespace questionnaireQuizz
{
    public partial class connexion : Form
    {
        MySqlConnection conn = Program.connection; // Appel de la méthode pour se connecter à la base de données

        public connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txt_motDePasse.Text.Trim();
            string identifiant = txt_id.Text.Trim();

            // On sélectionne uniquement le mot de passe haché pour l'utilisateur donné
            string query = "SELECT mot_passe_utilisateur FROM utilisateur WHERE nom_utilisateur = @identifiant";

            try
            {
                // Ouvrir la connexion si ce n'est pas déjà fait
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@identifiant", identifiant);

                    // Exécuter la requête pour récupérer le mot de passe haché
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string hashedPassword = result.ToString();

                        // Vérification du mot de passe avec BCrypt
                        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

                        if (isPasswordValid)
                        {
                           // MessageBox.Show("Connexion réussie !");
                            // Masquer la fenêtre de connexion et ouvrir la fenêtre principale de l'application
                            this.Hide();
                            Form1 mainForm = new Form1();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrect !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
            }
        }

        private void txt_creerCompte_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.ShowDialog();
            this.Close();
        }
    }
}
