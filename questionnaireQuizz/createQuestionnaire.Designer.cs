namespace questionnaireQuizz
{
    partial class createQuestionnaire
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
            rtb_nomQuestionnaire = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            cb_themeQuestionnaire = new ComboBox();
            btn_valider = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 62);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Créer un Questionnaire";
            // 
            // rtb_nomQuestionnaire
            // 
            rtb_nomQuestionnaire.Location = new Point(296, 109);
            rtb_nomQuestionnaire.Name = "rtb_nomQuestionnaire";
            rtb_nomQuestionnaire.Size = new Size(184, 33);
            rtb_nomQuestionnaire.TabIndex = 1;
            rtb_nomQuestionnaire.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 122);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Choisir un nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 168);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Choisir un thème";
            // 
            // cb_themeQuestionnaire
            // 
            cb_themeQuestionnaire.FormattingEnabled = true;
            cb_themeQuestionnaire.Location = new Point(308, 160);
            cb_themeQuestionnaire.Name = "cb_themeQuestionnaire";
            cb_themeQuestionnaire.Size = new Size(151, 28);
            cb_themeQuestionnaire.TabIndex = 4;
            // 
            // btn_valider
            // 
            btn_valider.Location = new Point(330, 235);
            btn_valider.Name = "btn_valider";
            btn_valider.Size = new Size(94, 29);
            btn_valider.TabIndex = 5;
            btn_valider.Text = "valider";
            btn_valider.UseVisualStyleBackColor = true;
            btn_valider.Click += btn_valider_Click;
            // 
            // createQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_valider);
            Controls.Add(cb_themeQuestionnaire);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rtb_nomQuestionnaire);
            Controls.Add(label1);
            Name = "createQuestionnaire";
            Text = "createQuestionnaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtb_nomQuestionnaire;
        private Label label2;
        private Label label3;
        private ComboBox cb_themeQuestionnaire;
        private Button btn_valider;
    }
}