using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
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

           // string connectionOFF = "Server=104.40.137.99;Port = 22260;Database=bdd_antoine_ppe;Uid=developer;Pwd=cerfal1313;";
           


           connection = new MySqlConnection(connectionString);
            //connection = new MySqlConnection(connectionOFF);


            try
            {
                
                connection.Open();
                MessageBox.Show("Connexion à la base de données réussie !");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erreur de connexion : " + ex.Message);
                return;  
            }

            
            Application.Run(new connexion());

            
            connection.Close();
        }
    }
}