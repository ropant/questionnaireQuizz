namespace questionnaireQuizz
{
    partial class connexion
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
            label1 = new Label();
            txt_identifiant = new Label();
            txt_password = new Label();
            button1 = new Button();
            txt_id = new TextBox();
            txt_motDePasse = new TextBox();
            txt_creerCompte = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 91);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Veuillez vous connecter";
            // 
            // txt_identifiant
            // 
            txt_identifiant.AutoSize = true;
            txt_identifiant.Location = new Point(219, 147);
            txt_identifiant.Name = "txt_identifiant";
            txt_identifiant.Size = new Size(77, 20);
            txt_identifiant.TabIndex = 1;
            txt_identifiant.Text = "Identifiant";
            // 
            // txt_password
            // 
            txt_password.AutoSize = true;
            txt_password.Location = new Point(219, 197);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(98, 20);
            txt_password.TabIndex = 2;
            txt_password.Text = "Mot de passe";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(375, 233);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 3;
            button1.Text = "connexion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(364, 140);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(157, 27);
            txt_id.TabIndex = 4;
            // 
            // txt_motDePasse
            // 
            txt_motDePasse.Location = new Point(364, 190);
            txt_motDePasse.Name = "txt_motDePasse";
            txt_motDePasse.Size = new Size(157, 27);
            txt_motDePasse.TabIndex = 5;
            // 
            // txt_creerCompte
            // 
            txt_creerCompte.AutoSize = true;
            txt_creerCompte.BackColor = SystemColors.ButtonFace;
            txt_creerCompte.Location = new Point(375, 265);
            txt_creerCompte.Name = "txt_creerCompte";
            txt_creerCompte.Size = new Size(131, 20);
            txt_creerCompte.TabIndex = 6;
            txt_creerCompte.Text = "créer mon compte";
            txt_creerCompte.Click += txt_creerCompte_Click;
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_creerCompte);
            Controls.Add(txt_motDePasse);
            Controls.Add(txt_id);
            Controls.Add(button1);
            Controls.Add(txt_password);
            Controls.Add(txt_identifiant);
            Controls.Add(label1);
            Name = "connexion";
            Text = "connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt_identifiant;
        private Label txt_password;
        private Button button1;
        private TextBox txt_id;
        private TextBox txt_motDePasse;
        private Label txt_creerCompte;
    }
}