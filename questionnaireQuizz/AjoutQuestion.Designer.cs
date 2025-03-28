namespace questionnaireQuizz
{
    partial class AjoutQuestion
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
            rtb_libelleQuestion = new RichTextBox();
            txt_question1 = new TextBox();
            txt_question2 = new TextBox();
            txt_question3 = new TextBox();
            txt_bonneReponse = new TextBox();
            bnt_valider = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cB_questionnaire = new ComboBox();
            SuspendLayout();
            // 
            // rtb_libelleQuestion
            // 
            rtb_libelleQuestion.Location = new Point(297, 127);
            rtb_libelleQuestion.Name = "rtb_libelleQuestion";
            rtb_libelleQuestion.Size = new Size(153, 36);
            rtb_libelleQuestion.TabIndex = 0;
            rtb_libelleQuestion.Text = "";
            // 
            // txt_question1
            // 
            txt_question1.Location = new Point(63, 214);
            txt_question1.Name = "txt_question1";
            txt_question1.Size = new Size(125, 27);
            txt_question1.TabIndex = 1;
            // 
            // txt_question2
            // 
            txt_question2.Location = new Point(222, 214);
            txt_question2.Name = "txt_question2";
            txt_question2.Size = new Size(125, 27);
            txt_question2.TabIndex = 2;
            // 
            // txt_question3
            // 
            txt_question3.Location = new Point(394, 214);
            txt_question3.Name = "txt_question3";
            txt_question3.Size = new Size(125, 27);
            txt_question3.TabIndex = 3;
            // 
            // txt_bonneReponse
            // 
            txt_bonneReponse.Location = new Point(553, 214);
            txt_bonneReponse.Name = "txt_bonneReponse";
            txt_bonneReponse.Size = new Size(125, 27);
            txt_bonneReponse.TabIndex = 4;
            // 
            // bnt_valider
            // 
            bnt_valider.Location = new Point(312, 335);
            bnt_valider.Name = "bnt_valider";
            bnt_valider.Size = new Size(94, 29);
            bnt_valider.TabIndex = 6;
            bnt_valider.Text = "Valider";
            bnt_valider.UseVisualStyleBackColor = true;
            bnt_valider.Click += bnt_valider_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 66);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 7;
            label1.Text = "Créer une Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 130);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 8;
            label2.Text = "Votre Question";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 182);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "reponse 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 182);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "reponse 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 180);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "reponse 3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 180);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 12;
            label6.Text = "Bonne reponse";
            // 
            // cB_questionnaire
            // 
            cB_questionnaire.FormattingEnabled = true;
            cB_questionnaire.Location = new Point(275, 271);
            cB_questionnaire.Name = "cB_questionnaire";
            cB_questionnaire.Size = new Size(151, 28);
            cB_questionnaire.TabIndex = 13;
            // 
            // AjoutQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cB_questionnaire);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bnt_valider);
            Controls.Add(txt_bonneReponse);
            Controls.Add(txt_question3);
            Controls.Add(txt_question2);
            Controls.Add(txt_question1);
            Controls.Add(rtb_libelleQuestion);
            Name = "AjoutQuestion";
            Text = "AjoutQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_libelleQuestion;
        private TextBox txt_question1;
        private TextBox txt_question2;
        private TextBox txt_question3;
        private TextBox txt_bonneReponse;
        private Button bnt_valider;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cB_questionnaire;
    }
}