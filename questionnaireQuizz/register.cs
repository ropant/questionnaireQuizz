using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;

namespace questionnaireQuizz
{
    public partial class register : Form
    {
        MySqlConnection conn = Program.connection;

        public register()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string identifiant = txt_identifiant.Text;
            string confirmPassword = txt_confirmPassword.Text;
            string email = label1.Text;

           
            if (password == confirmPassword)
            {
                try
                {
                   
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


                    // Requête SQL pour insérer un nouvel utilisateur
                    string query = "INSERT INTO utilisateur (nom_utilisateur, mot_passe_utilisateur, email) VALUES (@identifiant, @password, @email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@identifiant", identifiant);
                        cmd.Parameters.AddWithValue("@password", hashedPassword); // Pensez à hacher le mot de passe en production
                        cmd.Parameters.AddWithValue("@email", email);

                        // Exécuter la requête
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enregistrement réussi !");
                            // Vous pouvez rediriger l'utilisateur vers une autre page ou fermer le formulaire ici
                            connexion mainform = new connexion();
                            mainform.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'enregistrement.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne concordent pas.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Laissez vide si non utilisé
        }
    }
}
