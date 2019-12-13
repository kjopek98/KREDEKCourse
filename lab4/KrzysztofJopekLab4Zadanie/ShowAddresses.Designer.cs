namespace KrzysztofJopekLab4Zadanie
{
    partial class ShowAddresses
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
            this.dataGridViewAddressShow = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddressShow
            // 
            this.dataGridViewAddressShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddressShow.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewAddressShow.Name = "dataGridViewAddressShow";
            this.dataGridViewAddressShow.RowHeadersWidth = 51;
            this.dataGridViewAddressShow.RowTemplate.Height = 24;
            this.dataGridViewAddressShow.Size = new System.Drawing.Size(686, 216);
            this.dataGridViewAddressShow.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(265, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 29);
            this.label13.TabIndex = 55;
            this.label13.Text = "Wszystkie adresy";
            // 
            // ShowAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 292);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewAddressShow);
            this.Name = "ShowAddresses";
            this.Text = "ShowAddresses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddressShow;
        private System.Windows.Forms.Label label13;
    }
}