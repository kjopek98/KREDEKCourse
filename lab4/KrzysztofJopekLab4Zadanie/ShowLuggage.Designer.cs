namespace KrzysztofJopekLab4Zadanie
{
    partial class ShowLuggage
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
            this.dataGridViewLuggageShow = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuggageShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLuggageShow
            // 
            this.dataGridViewLuggageShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLuggageShow.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewLuggageShow.Name = "dataGridViewLuggageShow";
            this.dataGridViewLuggageShow.RowHeadersWidth = 51;
            this.dataGridViewLuggageShow.RowTemplate.Height = 24;
            this.dataGridViewLuggageShow.Size = new System.Drawing.Size(317, 189);
            this.dataGridViewLuggageShow.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(29, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "Rodzaje pakietów bagaży";
            // 
            // ShowLuggage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 263);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewLuggageShow);
            this.Name = "ShowLuggage";
            this.Text = "ShowLuggage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuggageShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLuggageShow;
        private System.Windows.Forms.Label label13;
    }
}