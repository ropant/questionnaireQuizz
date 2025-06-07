namespace questionnaireQuizz
{
    partial class FrmDureeConnexion
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
            dgvDurees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDurees).BeginInit();
            SuspendLayout();
            // 
            // dgvDurees
            // 
            dgvDurees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDurees.Location = new Point(100, 46);
            dgvDurees.Name = "dgvDurees";
            dgvDurees.RowHeadersWidth = 51;
            dgvDurees.Size = new Size(525, 338);
            dgvDurees.TabIndex = 0;
            // 
            // FrmDureeConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDurees);
            Name = "FrmDureeConnexion";
            Text = "FrmDureeConnexion";
            Load += FrmDureeConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDurees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDurees;
    }
}