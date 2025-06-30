using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace questionnaireQuizz
{
    public partial class utilisateurAdmin : Form
    {
        private readonly MySqlConnection _conn = Program.connection;
        private MySqlDataAdapter _adapter;
        private DataTable _dataTable;
        private BindingSource _bindingSource;

        public utilisateurAdmin()
        {
            InitializeComponent();

            // On « détache » l’ancre du DataGridView pour qu’il occupe tout l’espace dispo
            dgv_utilisateur.Dock = DockStyle.Fill;

            // On charge la grille au chargement du formulaire
            this.Load += UtilisateurAdmin_Load;
        }

        private void UtilisateurAdmin_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        /// <summary>
        /// Lit la table `utilisateur` et lie les résultats au DataGridView.
        /// </summary>
        private void ChargerUtilisateurs()
        {
            const string sql =
                @"SELECT 
                    
                    nom_utilisateur,
                    token,
                    role,
                    email,
                    essai,
                    rgpd,
                    Activation
                  FROM utilisateur;";

            try
            {
                // 1) Ouvre la connexion si nécessaire
                if (_conn.State != ConnectionState.Open)
                    _conn.Open();

                // 2) Remplit le DataTable à l’aide d’un DataAdapter
                using (var cmd = new MySqlCommand(sql, _conn))
                {
                    _adapter = new MySqlDataAdapter(cmd);

                    // Le CommandBuilder permet de générer automatiquement les requêtes UPDATE/DELETE/INSERT
                    var builder = new MySqlCommandBuilder(_adapter)
                    {
                        ConflictOption = ConflictOption.OverwriteChanges
                    };

                    _dataTable = new DataTable();
                    _adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    _adapter.Fill(_dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des utilisateurs :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }

            // 3) On lie le DataTable à un BindingSource pour gérer plus facilement l’update
            _bindingSource = new BindingSource
            {
                DataSource = _dataTable
            };

            dgv_utilisateur.DataSource = _bindingSource;
            dgv_utilisateur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 4) On abonne l’événement RowValidated pour propager les modifications vers la bdd
            dgv_utilisateur.RowValidated -= Dgv_utilisateur_RowValidated; // au cas où il y aurait un double-abonnement
            dgv_utilisateur.RowValidated += Dgv_utilisateur_RowValidated;
        }

        /// <summary>
        /// Lorsque l’utilisateur édite une ligne (RowValidated), on appelle adapter.Update(...) 
        /// pour envoyer les modifications back en base.
        /// </summary>
        private void Dgv_utilisateur_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (_adapter == null || _dataTable == null)
                return;

            try
            {
                // _adapter a déjà un MySqlCommandBuilder associé, donc Update() génère les requêtes SQL nécessaires
                _adapter.Update(_dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'enregistrer les modifications :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_validerModif_Click(object sender, EventArgs e)
        {
            // 1) On ré‐ouvre la connexion si nécessaire
            try
            {
                if (_conn.State != ConnectionState.Open)
                    _conn.Open();

                // 2) On applique les modifications éventuellement non encore propagées
                //    (même si RowValidated a déjà tenté un Update, on s’assure ici de tout pousser)
                if (_adapter != null && _dataTable != null)
                {
                    _adapter.Update(_dataTable);
                }

                // 3) On ferme ce formulaire : on revient sur Form1 (car Form1 a été caché avant ShowDialog)
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement final :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
    }
    
}
