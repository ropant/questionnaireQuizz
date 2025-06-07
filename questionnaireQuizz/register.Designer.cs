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
            lbl_3 = new Label();
            lbl_2 = new Label();
            lbl_1 = new Label();
            lbl_5 = new Label();
            textBox1 = new TextBox();
            lbl_4 = new Label();
            SuspendLayout();
            // 
            // txt_identifiant
            // 
            txt_identifiant.Location = new Point(362, 176);
            txt_identifiant.Name = "txt_identifiant";
            txt_identifiant.Size = new Size(125, 27);
            txt_identifiant.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(362, 212);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 1;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(362, 245);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.Size = new Size(125, 27);
            txt_confirmPassword.TabIndex = 2;
            // 
            // btn_createAccount
            // 
            btn_createAccount.Location = new Point(332, 303);
            btn_createAccount.Name = "btn_createAccount";
            btn_createAccount.Size = new Size(177, 33);
            btn_createAccount.TabIndex = 3;
            btn_createAccount.Text = "Créer mon compte";
            btn_createAccount.UseVisualStyleBackColor = true;
            btn_createAccount.Click += btn_createAccount_Click;
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Location = new Point(245, 179);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(77, 20);
            lbl_3.TabIndex = 4;
            lbl_3.Text = "identifiant";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(220, 215);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(102, 20);
            lbl_2.TabIndex = 5;
            lbl_2.Text = "mot de passe ";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(112, 248);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(210, 20);
            lbl_1.TabIndex = 6;
            lbl_1.Text = "confirmez votre mot de passe ";
            // 
            // lbl_5
            // 
            lbl_5.AutoSize = true;
            lbl_5.Location = new Point(344, 62);
            lbl_5.Name = "lbl_5";
            lbl_5.Size = new Size(190, 20);
            lbl_5.TabIndex = 7;
            lbl_5.Text = "Veuillez créer votre compte";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Location = new Point(276, 139);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(46, 20);
            lbl_4.TabIndex = 9;
            lbl_4.Text = "Email";
            lbl_4.Click += label1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_4);
            Controls.Add(textBox1);
            Controls.Add(lbl_5);
            Controls.Add(lbl_1);
            Controls.Add(lbl_2);
            Controls.Add(lbl_3);
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
        private Label lbl_3;
        private Label lbl_2;
        private Label lbl_1;
        private Label lbl_5;
        private TextBox textBox1;
        private Label lbl_4;
    }
}