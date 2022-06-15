namespace LegoExerciseForm
{
    partial class FormSorting
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
            this.dataGridVendors = new System.Windows.Forms.DataGridView();
            this.textBoxVendors = new System.Windows.Forms.TextBox();
            this.dataGridMaterials = new System.Windows.Forms.DataGridView();
            this.textBoxMaterials = new System.Windows.Forms.TextBox();
            this.buttonCheapestMaterials = new System.Windows.Forms.Button();
            this.buttonFindBest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVendors
            // 
            this.dataGridVendors.AllowUserToAddRows = false;
            this.dataGridVendors.AllowUserToDeleteRows = false;
            this.dataGridVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendors.Location = new System.Drawing.Point(12, 41);
            this.dataGridVendors.Name = "dataGridVendors";
            this.dataGridVendors.ReadOnly = true;
            this.dataGridVendors.RowTemplate.Height = 25;
            this.dataGridVendors.Size = new System.Drawing.Size(611, 150);
            this.dataGridVendors.TabIndex = 1;
            this.dataGridVendors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendors_CellClick);
            this.dataGridVendors.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridVendors_ColumnHeaderMouseClick);
            // 
            // textBoxVendors
            // 
            this.textBoxVendors.Location = new System.Drawing.Point(12, 12);
            this.textBoxVendors.Name = "textBoxVendors";
            this.textBoxVendors.ReadOnly = true;
            this.textBoxVendors.Size = new System.Drawing.Size(100, 23);
            this.textBoxVendors.TabIndex = 2;
            this.textBoxVendors.Text = "Vendors";
            // 
            // dataGridMaterials
            // 
            this.dataGridMaterials.AllowUserToAddRows = false;
            this.dataGridMaterials.AllowUserToDeleteRows = false;
            this.dataGridMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterials.Location = new System.Drawing.Point(12, 275);
            this.dataGridMaterials.Name = "dataGridMaterials";
            this.dataGridMaterials.ReadOnly = true;
            this.dataGridMaterials.RowTemplate.Height = 25;
            this.dataGridMaterials.Size = new System.Drawing.Size(940, 150);
            this.dataGridMaterials.TabIndex = 3;
            this.dataGridMaterials.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMaterials_ColumnHeaderMouseClick);
            // 
            // textBoxMaterials
            // 
            this.textBoxMaterials.Location = new System.Drawing.Point(12, 246);
            this.textBoxMaterials.Name = "textBoxMaterials";
            this.textBoxMaterials.ReadOnly = true;
            this.textBoxMaterials.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaterials.TabIndex = 4;
            this.textBoxMaterials.Text = "Materials";
            // 
            // buttonCheapestMaterials
            // 
            this.buttonCheapestMaterials.Location = new System.Drawing.Point(659, 41);
            this.buttonCheapestMaterials.Name = "buttonCheapestMaterials";
            this.buttonCheapestMaterials.Size = new System.Drawing.Size(139, 23);
            this.buttonCheapestMaterials.TabIndex = 5;
            this.buttonCheapestMaterials.Text = "Find cheapest materials";
            this.buttonCheapestMaterials.UseVisualStyleBackColor = true;
            this.buttonCheapestMaterials.Click += new System.EventHandler(this.buttonCheapestMaterials_Click);
            // 
            // buttonFindBest
            // 
            this.buttonFindBest.Location = new System.Drawing.Point(659, 137);
            this.buttonFindBest.Name = "buttonFindBest";
            this.buttonFindBest.Size = new System.Drawing.Size(139, 23);
            this.buttonFindBest.TabIndex = 6;
            this.buttonFindBest.Text = "Find Best PMMA";
            this.buttonFindBest.UseVisualStyleBackColor = true;
            this.buttonFindBest.Click += new System.EventHandler(this.buttonFindBest_Click);
            // 
            // FormSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.buttonFindBest);
            this.Controls.Add(this.buttonCheapestMaterials);
            this.Controls.Add(this.textBoxMaterials);
            this.Controls.Add(this.dataGridMaterials);
            this.Controls.Add(this.textBoxVendors);
            this.Controls.Add(this.dataGridVendors);
            this.Name = "FormSorting";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVendors;
        private System.Windows.Forms.TextBox textBoxVendors;
        private System.Windows.Forms.DataGridView dataGridMaterials;
        private System.Windows.Forms.TextBox textBoxMaterials;
        private System.Windows.Forms.Button buttonCheapestMaterials;
        private System.Windows.Forms.Button buttonFindBest;
    }
}
