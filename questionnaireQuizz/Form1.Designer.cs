namespace questionnaireQuizz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_afficherQuestion = new Button();
            dataGridView_questions = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip_AddTOQuestionnaire = new ToolStripMenuItem();
            modifierUneQuestionToolStripMenuItem = new ToolStripMenuItem();
            créerUnQuestionnaireToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(302, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(140, 52);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 1;
            button1.Text = "Choix du thème";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_afficherThemes_Click;
            // 
            // btn_afficherQuestion
            // 
            btn_afficherQuestion.BackColor = SystemColors.ControlLight;
            btn_afficherQuestion.Location = new Point(388, 52);
            btn_afficherQuestion.Name = "btn_afficherQuestion";
            btn_afficherQuestion.Size = new Size(179, 29);
            btn_afficherQuestion.TabIndex = 2;
            btn_afficherQuestion.Text = "Afficher les questions";
            btn_afficherQuestion.UseVisualStyleBackColor = false;
            btn_afficherQuestion.Click += btn_afficherQuestion_Click;
            // 
            // dataGridView_questions
            // 
            dataGridView_questions.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_questions.ContextMenuStrip = contextMenuStrip1;
            dataGridView_questions.Location = new Point(363, 109);
            dataGridView_questions.Name = "dataGridView_questions";
            dataGridView_questions.RowHeadersWidth = 51;
            dataGridView_questions.Size = new Size(315, 231);
            dataGridView_questions.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_AddTOQuestionnaire, modifierUneQuestionToolStripMenuItem, créerUnQuestionnaireToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(353, 104);
            // 
            // toolStrip_AddTOQuestionnaire
            // 
            toolStrip_AddTOQuestionnaire.Name = "toolStrip_AddTOQuestionnaire";
            toolStrip_AddTOQuestionnaire.Size = new Size(352, 24);
            toolStrip_AddTOQuestionnaire.Text = "Créer une Question";
            toolStrip_AddTOQuestionnaire.Click += toolStrip_AddTOQuestionnaire_Click;
            // 
            // modifierUneQuestionToolStripMenuItem
            // 
            modifierUneQuestionToolStripMenuItem.Name = "modifierUneQuestionToolStripMenuItem";
            modifierUneQuestionToolStripMenuItem.Size = new Size(352, 24);
            modifierUneQuestionToolStripMenuItem.Text = "Attribuer une question à un questionnaire";
            modifierUneQuestionToolStripMenuItem.Click += modifierUneQuestionToolStripMenuItem_Click;
            // 
            // créerUnQuestionnaireToolStripMenuItem
            // 
            créerUnQuestionnaireToolStripMenuItem.Name = "créerUnQuestionnaireToolStripMenuItem";
            créerUnQuestionnaireToolStripMenuItem.Size = new Size(352, 24);
            créerUnQuestionnaireToolStripMenuItem.Text = "Créer un questionnaire";
            créerUnQuestionnaireToolStripMenuItem.Click += créerUnQuestionnaireToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_questions);
            Controls.Add(btn_afficherQuestion);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_afficherQuestion;
        private DataGridView dataGridView_questions;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStrip_AddTOQuestionnaire;
        private ToolStripMenuItem modifierUneQuestionToolStripMenuItem;
        private ToolStripMenuItem créerUnQuestionnaireToolStripMenuItem;
    }
}
