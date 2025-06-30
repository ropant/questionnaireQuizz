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
            menuStrip1 = new MenuStrip();
            voirLesUtilisateursToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            createTheme = new ToolStripMenuItem();
            afficherLesQuestionsToolStripMenuItem = new ToolStripMenuItem();
            afficherLesQuestionnairesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            txt_nom = new TextBox();
            txt_id = new TextBox();
            btn_getID = new Button();
            btn_deconnecter = new Button();
            label1 = new Label();
            txt_nbrConnexion = new TextBox();
            txt_derniereConnection = new TextBox();
            label2 = new Label();
            btn_afficherQuestionnaire = new Button();
            btn_filtre = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            contextMenuStrip1.Size = new Size(353, 76);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voirLesUtilisateursToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, createTheme, afficherLesQuestionsToolStripMenuItem, afficherLesQuestionnairesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // voirLesUtilisateursToolStripMenuItem
            // 
            voirLesUtilisateursToolStripMenuItem.Name = "voirLesUtilisateursToolStripMenuItem";
            voirLesUtilisateursToolStripMenuItem.Size = new Size(146, 24);
            voirLesUtilisateursToolStripMenuItem.Text = "Voir les utilisateurs";
            voirLesUtilisateursToolStripMenuItem.Click += voirLesUtilisateursToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 24);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(14, 24);
            // 
            // createTheme
            // 
            createTheme.Name = "createTheme";
            createTheme.Size = new Size(124, 24);
            createTheme.Text = "Créer un thème";
            createTheme.Click += createTheme_Click_1;
            // 
            // afficherLesQuestionsToolStripMenuItem
            // 
            afficherLesQuestionsToolStripMenuItem.Name = "afficherLesQuestionsToolStripMenuItem";
            afficherLesQuestionsToolStripMenuItem.Size = new Size(164, 24);
            afficherLesQuestionsToolStripMenuItem.Text = "Afficher les questions";
            afficherLesQuestionsToolStripMenuItem.Click += afficherLesQuestionsToolStripMenuItem_Click;
            // 
            // afficherLesQuestionnairesToolStripMenuItem
            // 
            afficherLesQuestionnairesToolStripMenuItem.Name = "afficherLesQuestionnairesToolStripMenuItem";
            afficherLesQuestionnairesToolStripMenuItem.Size = new Size(197, 24);
            afficherLesQuestionnairesToolStripMenuItem.Text = "Afficher les questionnaires";
            afficherLesQuestionnairesToolStripMenuItem.Click += afficherLesQuestionnairesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(83, 26);
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(0, 413);
            txt_nom.Name = "txt_nom";
            txt_nom.Size = new Size(125, 27);
            txt_nom.TabIndex = 5;
            txt_nom.TextChanged += txt_nom_TextChanged;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(140, 413);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 7;
            // 
            // btn_getID
            // 
            btn_getID.Location = new Point(0, 378);
            btn_getID.Name = "btn_getID";
            btn_getID.Size = new Size(202, 29);
            btn_getID.TabIndex = 8;
            btn_getID.Text = "tapez pour retrouver l'id";
            btn_getID.UseVisualStyleBackColor = true;
            btn_getID.Click += btn_getID_Click;
            // 
            // btn_deconnecter
            // 
            btn_deconnecter.Location = new Point(701, 391);
            btn_deconnecter.Name = "btn_deconnecter";
            btn_deconnecter.Size = new Size(99, 60);
            btn_deconnecter.TabIndex = 9;
            btn_deconnecter.Text = "Se Déconnecter";
            btn_deconnecter.UseVisualStyleBackColor = true;
            btn_deconnecter.Click += btn_deconnecter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(419, 376);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 10;
            label1.Text = "nbr_connexion";
            // 
            // txt_nbrConnexion
            // 
            txt_nbrConnexion.Location = new Point(530, 373);
            txt_nbrConnexion.Name = "txt_nbrConnexion";
            txt_nbrConnexion.Size = new Size(125, 27);
            txt_nbrConnexion.TabIndex = 11;
            // 
            // txt_derniereConnection
            // 
            txt_derniereConnection.Location = new Point(530, 406);
            txt_derniereConnection.Name = "txt_derniereConnection";
            txt_derniereConnection.Size = new Size(125, 27);
            txt_derniereConnection.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(388, 411);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 13;
            label2.Text = "dernière connexion";
            // 
            // btn_afficherQuestionnaire
            // 
            btn_afficherQuestionnaire.Location = new Point(388, 87);
            btn_afficherQuestionnaire.Name = "btn_afficherQuestionnaire";
            btn_afficherQuestionnaire.Size = new Size(290, 29);
            btn_afficherQuestionnaire.TabIndex = 14;
            btn_afficherQuestionnaire.Text = "Questionnaire obsolète";
            btn_afficherQuestionnaire.UseVisualStyleBackColor = true;
            btn_afficherQuestionnaire.Click += btn_afficherQuestionnaire_Click;
            // 
            // btn_filtre
            // 
            btn_filtre.Location = new Point(140, 87);
            btn_filtre.Name = "btn_filtre";
            btn_filtre.Size = new Size(94, 29);
            btn_filtre.TabIndex = 15;
            btn_filtre.Text = "Sans questionnaire ";
            btn_filtre.UseVisualStyleBackColor = true;
            btn_filtre.Click += btn_filtre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_filtre);
            Controls.Add(btn_afficherQuestionnaire);
            Controls.Add(label2);
            Controls.Add(txt_derniereConnection);
            Controls.Add(txt_nbrConnexion);
            Controls.Add(label1);
            Controls.Add(btn_deconnecter);
            Controls.Add(btn_getID);
            Controls.Add(txt_id);
            Controls.Add(txt_nom);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView_questions);
            Controls.Add(btn_afficherQuestion);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voirLesUtilisateursToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem createTheme;
        private ToolStripMenuItem afficherLesQuestionsToolStripMenuItem;
        private ToolStripMenuItem afficherLesQuestionnairesToolStripMenuItem;
        private TextBox txt_nom;
        private TextBox txt_id;
        private Button btn_getID;
        private Button btn_deconnecter;
        private Label label1;
        private TextBox txt_nbrConnexion;
        private TextBox txt_derniereConnection;
        private Label label2;
        private Button btn_afficherQuestionnaire;
        private Button btn_filtre;
    }
}
