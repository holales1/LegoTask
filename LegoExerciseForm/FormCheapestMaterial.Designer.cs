
namespace LegoExerciseForm
{
    partial class FormCheapestMaterial
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
            this.dataGridCheapestMaterials = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheapestMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCheapestMaterials
            // 
            this.dataGridCheapestMaterials.AllowUserToAddRows = false;
            this.dataGridCheapestMaterials.AllowUserToDeleteRows = false;
            this.dataGridCheapestMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCheapestMaterials.Location = new System.Drawing.Point(12, 134);
            this.dataGridCheapestMaterials.Name = "dataGridCheapestMaterials";
            this.dataGridCheapestMaterials.ReadOnly = true;
            this.dataGridCheapestMaterials.RowTemplate.Height = 25;
            this.dataGridCheapestMaterials.Size = new System.Drawing.Size(1029, 150);
            this.dataGridCheapestMaterials.TabIndex = 0;
            this.dataGridCheapestMaterials.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCheapestMaterials_ColumnHeaderMouseClick);
            // 
            // FormCheapestMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.dataGridCheapestMaterials);
            this.Name = "FormCheapestMaterial";
            this.Text = "FormCheapestMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheapestMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCheapestMaterials;
    }
}