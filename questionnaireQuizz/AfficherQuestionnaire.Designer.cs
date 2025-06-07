namespace questionnaireQuizz
{
    partial class AfficherQuestionnaire
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
            btn_createPDF = new Button();
            SuspendLayout();
            // 
            // btn_createPDF
            // 
            btn_createPDF.Location = new Point(276, 136);
            btn_createPDF.Name = "btn_createPDF";
            btn_createPDF.Size = new Size(179, 110);
            btn_createPDF.TabIndex = 0;
            btn_createPDF.Text = "Générer un PDF ";
            btn_createPDF.UseVisualStyleBackColor = true;
            btn_createPDF.Click += btn_createPDF_Click;
            // 
            // AfficherQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_createPDF);
            Name = "AfficherQuestionnaire";
            Text = "AfficherQuestionnaire";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_createPDF;
    }
}