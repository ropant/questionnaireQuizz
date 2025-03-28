namespace questionnaireQuizz
{
    partial class questions
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
            lbl_theme = new Label();
            datagrd_questions = new DataGridView();
            btn_backTheme = new Button();
            ((System.ComponentModel.ISupportInitialize)datagrd_questions).BeginInit();
            SuspendLayout();
            // 
            // lbl_theme
            // 
            lbl_theme.AutoSize = true;
            lbl_theme.Location = new Point(372, 43);
            lbl_theme.Name = "lbl_theme";
            lbl_theme.Size = new Size(50, 20);
            lbl_theme.TabIndex = 0;
            lbl_theme.Text = "label1";
            // 
            // datagrd_questions
            // 
            datagrd_questions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrd_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrd_questions.Location = new Point(183, 81);
            datagrd_questions.Name = "datagrd_questions";
            datagrd_questions.RowHeadersWidth = 51;
            datagrd_questions.Size = new Size(438, 188);
            datagrd_questions.TabIndex = 1;
            // 
            // btn_backTheme
            // 
            btn_backTheme.Location = new Point(251, 289);
            btn_backTheme.Name = "btn_backTheme";
            btn_backTheme.Size = new Size(314, 35);
            btn_backTheme.TabIndex = 2;
            btn_backTheme.Text = "BACK TO THEME";
            btn_backTheme.UseVisualStyleBackColor = true;
            btn_backTheme.Click += btn_backTheme_Click;
            // 
            // questions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_backTheme);
            Controls.Add(datagrd_questions);
            Controls.Add(lbl_theme);
            Name = "questions";
            Text = "questions";
            ((System.ComponentModel.ISupportInitialize)datagrd_questions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_theme;
        private DataGridView datagrd_questions;
        private Button btn_backTheme;
    }
}