namespace questionnaireQuizz
{
    partial class utilisateurAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_utilisateur = new DataGridView();
            btn_validerModif = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_utilisateur).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_utilisateur
            // 
            dgv_utilisateur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_utilisateur.Dock = DockStyle.Fill;
            dgv_utilisateur.Location = new Point(0, 0);
            dgv_utilisateur.Name = "dgv_utilisateur";
            dgv_utilisateur.RowHeadersWidth = 51;
            dgv_utilisateur.Size = new Size(800, 450);
            dgv_utilisateur.TabIndex = 0;
            // 
            // btn_validerModif
            // 
            btn_validerModif.Location = new Point(279, 3);
            btn_validerModif.Name = "btn_validerModif";
            btn_validerModif.Size = new Size(239, 29);
            btn_validerModif.TabIndex = 2;
            btn_validerModif.Text = "Valider les modifications";
            btn_validerModif.UseVisualStyleBackColor = true;
            btn_validerModif.Click += btn_validerModif_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_validerModif);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 32);
            panel1.TabIndex = 3;
            // 
            // utilisateurAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgv_utilisateur);
            Name = "utilisateurAdmin";
            Text = "utilisateurAdmin";
            ((System.ComponentModel.ISupportInitialize)dgv_utilisateur).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_utilisateur;
        private Button btn_validerModif;
        private Panel panel1;
    }
}