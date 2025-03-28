using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    internal static class Program
    {
        // Variable statique pour la connexion
        internal static MySqlConnection connection;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Définissez ici votre chaîne de connexion
            string connectionString = "Server=localhost;Database=questionnaire;Uid=root;Pwd=;";

            // Instancier la connexion
            connection = new MySqlConnection(connectionString);

            try
            {
                // Tentative d'ouverture
                connection.Open();
                MessageBox.Show("Connexion à la base de données réussie !");
            }
            catch (Exception ex)
            {
                // Si erreur, on l’affiche et on arrête l’application
                MessageBox.Show("Erreur de connexion : " + ex.Message);
                return;  
            }

            // Si la connexion est réussie, lancer le formulaire principal
            Application.Run(new connexion());

            
            connection.Close();
        }
    }
}