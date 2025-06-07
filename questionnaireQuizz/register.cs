using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace questionnaireQuizz
{
    public partial class register : Form
    {
        MySqlConnection conn = Program.connection;

        public register()
        {
            InitializeComponent();
            // 1) POLICE ET FOND DU FORM
            // =======================
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.BackColor = Color.Snow;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;



            lbl_1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl_1.ForeColor = Color.FromArgb(51, 51, 51); // #333333
            lbl_1.AutoSize = true;

            lbl_2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl_2.ForeColor = Color.FromArgb(51, 51, 51);
            lbl_2.AutoSize = true;

            lbl_3.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl_3.ForeColor = Color.FromArgb(51, 51, 51);
            lbl_3.AutoSize = true;

            lbl_4.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl_4.ForeColor = Color.FromArgb(51, 51, 51);
            lbl_4.AutoSize = true;

            lbl_5.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lbl_5.ForeColor = Color.FromArgb(51, 51, 51);
            lbl_5.AutoSize = true;

            //input box 
            
            txt_identifiant.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txt_identifiant.ForeColor = Color.FromArgb(51, 51, 51);
            txt_identifiant.BackColor = Color.White;
            txt_identifiant.BorderStyle = BorderStyle.FixedSingle;

            txt_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txt_password.ForeColor = Color.FromArgb(51, 51, 51);
            txt_password.BackColor = Color.White;
            txt_password.BorderStyle = BorderStyle.FixedSingle;

            txt_confirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txt_confirmPassword.ForeColor = Color.FromArgb(51, 51, 51);
            txt_confirmPassword.BackColor = Color.White;
            txt_confirmPassword.BorderStyle = BorderStyle.FixedSingle;

            // Si vous avez un champ “Email” nommé textBox1, faites pareil :
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            textBox1.ForeColor = Color.FromArgb(51, 51, 51);
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            // =======================
            // 3) STYLISER LE BOUTON “Créer mon compte” (btn_createAccount)
            // =======================
            btn_createAccount.Text = "Créer mon compte";
            btn_createAccount.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btn_createAccount.BackColor = Color.FromArgb(0, 120, 215);     // bleu (#0078D7)
            btn_createAccount.ForeColor = Color.White;
            btn_createAccount.FlatStyle = FlatStyle.Flat;
            btn_createAccount.FlatAppearance.BorderSize = 0;
            btn_createAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 180);
            btn_createAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 170);
            
            
            
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string identifiant = txt_identifiant.Text;
            string confirmPassword = txt_confirmPassword.Text;
            string email = textBox1.Text;

           
            if (password == confirmPassword)
            {
                try
                {
                   
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


                    // Requête SQL pour insérer un nouvel utilisateur
                    string query = " INSERT INTO utilisateur(nom_utilisateur, mot_passe_utilisateur, email, Activation) VALUES(@identifiant, @password, @email, 0);";

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
