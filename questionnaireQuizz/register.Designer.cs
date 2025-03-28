namespace questionnaireQuizz
{
    partial class register
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
            txt_identifiant = new TextBox();
            txt_password = new TextBox();
            txt_confirmPassword = new TextBox();
            btn_createAccount = new Button();
            lbl_identifiant = new Label();
            lbl_password = new Label();
            lbl_confirmPassword = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_identifiant
            // 
            txt_identifiant.Location = new Point(372, 179);
            txt_identifiant.Name = "txt_identifiant";
            txt_identifiant.Size = new Size(125, 27);
            txt_identifiant.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(372, 212);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 1;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(372, 245);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.Size = new Size(125, 27);
            txt_confirmPassword.TabIndex = 2;
            // 
            // btn_createAccount
            // 
            btn_createAccount.Location = new Point(359, 345);
            btn_createAccount.Name = "btn_createAccount";
            btn_createAccount.Size = new Size(153, 33);
            btn_createAccount.TabIndex = 3;
            btn_createAccount.Text = "Créer mon compte";
            btn_createAccount.UseVisualStyleBackColor = true;
            btn_createAccount.Click += btn_createAccount_Click;
            // 
            // lbl_identifiant
            // 
            lbl_identifiant.AutoSize = true;
            lbl_identifiant.Location = new Point(276, 182);
            lbl_identifiant.Name = "lbl_identifiant";
            lbl_identifiant.Size = new Size(77, 20);
            lbl_identifiant.TabIndex = 4;
            lbl_identifiant.Text = "identifiant";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(241, 212);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(102, 20);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "mot de passe ";
            // 
            // lbl_confirmPassword
            // 
            lbl_confirmPassword.AutoSize = true;
            lbl_confirmPassword.Location = new Point(143, 248);
            lbl_confirmPassword.Name = "lbl_confirmPassword";
            lbl_confirmPassword.Size = new Size(210, 20);
            lbl_confirmPassword.TabIndex = 6;
            lbl_confirmPassword.Text = "confirmez votre mot de passe ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 43);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 7;
            label4.Text = "veuillez créer votre compte";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 139);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 9;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(lbl_confirmPassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_identifiant);
            Controls.Add(btn_createAccount);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_password);
            Controls.Add(txt_identifiant);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_identifiant;
        private TextBox txt_password;
        private TextBox txt_confirmPassword;
        private Button btn_createAccount;
        private Label lbl_identifiant;
        private Label lbl_password;
        private Label lbl_confirmPassword;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
    }
}