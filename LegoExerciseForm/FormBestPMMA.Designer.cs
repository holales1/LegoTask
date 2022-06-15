
namespace LegoExerciseForm
{
    partial class FormBestPMMA
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
            this.dataGridBestPMMA = new System.Windows.Forms.DataGridView();
            this.buttonFindBest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBestPMMA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBestPMMA
            // 
            this.dataGridBestPMMA.AllowUserToAddRows = false;
            this.dataGridBestPMMA.AllowUserToDeleteRows = false;
            this.dataGridBestPMMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBestPMMA.Location = new System.Drawing.Point(12, 138);
            this.dataGridBestPMMA.Name = "dataGridBestPMMA";
            this.dataGridBestPMMA.ReadOnly = true;
            this.dataGridBestPMMA.RowTemplate.Height = 25;
            this.dataGridBestPMMA.Size = new System.Drawing.Size(1016, 150);
            this.dataGridBestPMMA.TabIndex = 0;
            // 
            // buttonFindBest
            // 
            this.buttonFindBest.Location = new System.Drawing.Point(494, 351);
            this.buttonFindBest.Name = "buttonFindBest";
            this.buttonFindBest.Size = new System.Drawing.Size(75, 23);
            this.buttonFindBest.TabIndex = 1;
            this.buttonFindBest.Text = "Find best";
            this.buttonFindBest.UseVisualStyleBackColor = true;
            this.buttonFindBest.Click += new System.EventHandler(this.buttonFindBest_Click);
            // 
            // FormBestPMMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.buttonFindBest);
            this.Controls.Add(this.dataGridBestPMMA);
            this.Name = "FormBestPMMA";
            this.Text = "FormBestPMMA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBestPMMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBestPMMA;
        private System.Windows.Forms.Button buttonFindBest;
    }
}