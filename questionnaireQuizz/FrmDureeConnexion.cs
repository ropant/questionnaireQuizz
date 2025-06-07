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
    public partial class FrmDureeConnexion : Form
    {
        // On suppose que Program.connection est la même connexion MySQL que vous utilisez ailleurs
        private MySqlConnection conn = Program.connection;

        public FrmDureeConnexion()
        {
            InitializeComponent();
        }

        private void FrmDureeConnexion_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                // 1) Mettre à jour en base toutes les durées manquantes
                string updateSql = @"
                    UPDATE temps_connexion
                       SET duree = TIMEDIFF(time_deconnexion, time_connexion)
                     WHERE time_deconnexion IS NOT NULL
                       AND duree IS NULL;
                ";

                using (var cmdUpd = new MySqlCommand(updateSql, conn))
                {
                    cmdUpd.ExecuteNonQuery();
                }

                // 2) Charger les données dans un DataTable (avec jointure pour récupérer le nom de l'utilisateur)
                string selectSql = @"
                    SELECT 
                        t.id_temps_connexion       AS 'ID Connexion',
                        u.nom_utilisateur          AS 'Utilisateur',
                        t.time_connexion           AS 'Heure Connexion',
                        t.time_deconnexion         AS 'Heure Déconnexion',
                        t.duree                    AS 'Durée (HH:MM:SS)'
                    FROM temps_connexion t
                    JOIN utilisateur u 
                      ON t.id_utilisateur = u.id_utilisateur
                    ORDER BY t.time_connexion DESC;
                ";

                DataTable dt = new DataTable();
                using (var cmdSel = new MySqlCommand(selectSql, conn))
                using (var adapter = new MySqlDataAdapter(cmdSel))
                {
                    adapter.Fill(dt);
                }

                // 3) Afficher dans le DataGridView
                dgvDurees.DataSource = dt;
                dgvDurees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des durées : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}