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
            label2 = new Label();
            button1 = new Button();
            txt_id = new TextBox();
            txt_motDePasse = new TextBox();
            txt_creerCompte = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(375, 96);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Veuillez vous connecter";
            // 
            // txt_identifiant
            // 
            txt_identifiant.AutoSize = true;
            txt_identifiant.BackColor = Color.White;
            txt_identifiant.Location = new Point(219, 147);
            txt_identifiant.Name = "txt_identifiant";
            txt_identifiant.Size = new Size(77, 20);
            txt_identifiant.TabIndex = 1;
            txt_identifiant.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(198, 197);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(384, 234);
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
            txt_id.Size = new Size(180, 27);
            txt_id.TabIndex = 4;
            // 
            // txt_motDePasse
            // 
            txt_motDePasse.Location = new Point(364, 190);
            txt_motDePasse.Name = "txt_motDePasse";
            txt_motDePasse.PasswordChar = '*';
            txt_motDePasse.Size = new Size(180, 27);
            txt_motDePasse.TabIndex = 5;
            // 
            // txt_creerCompte
            // 
            txt_creerCompte.AutoSize = true;
            txt_creerCompte.BackColor = SystemColors.HighlightText;
            txt_creerCompte.Location = new Point(384, 276);
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
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_creerCompte);
            Controls.Add(txt_motDePasse);
            Controls.Add(txt_id);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txt_identifiant);
            Controls.Add(label1);
            Name = "connexion";
            Text = "connexion";
            Load += connexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt_identifiant;
        private Label label2;
        private Button button1;
        private TextBox txt_id;
        private TextBox txt_motDePasse;
        private Label txt_creerCompte;
    }
}