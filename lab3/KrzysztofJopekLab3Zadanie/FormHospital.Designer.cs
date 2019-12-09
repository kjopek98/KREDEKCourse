namespace KrzysztofJopekLab3Zadanie
{
    partial class FormHospital
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
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.buttonOkulista = new System.Windows.Forms.Button();
            this.buttonRemoveRow = new System.Windows.Forms.Button();
            this.buttonAddNewRow = new System.Windows.Forms.Button();
            this.buttonPsychiatra = new System.Windows.Forms.Button();
            this.buttonGinekolog = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonShowDoctors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(27, 55);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.RowHeadersWidth = 51;
            this.dataGridViewWarehouse.RowTemplate.Height = 24;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(827, 257);
            this.dataGridViewWarehouse.TabIndex = 0;
            // 
            // buttonOkulista
            // 
            this.buttonOkulista.Location = new System.Drawing.Point(884, 55);
            this.buttonOkulista.Name = "buttonOkulista";
            this.buttonOkulista.Size = new System.Drawing.Size(200, 71);
            this.buttonOkulista.TabIndex = 3;
            this.buttonOkulista.Text = "Filtrowanie Okulista";
            this.buttonOkulista.UseVisualStyleBackColor = true;
            this.buttonOkulista.Click += new System.EventHandler(this.buttonOkulista_Click);
            // 
            // buttonRemoveRow
            // 
            this.buttonRemoveRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRemoveRow.Location = new System.Drawing.Point(27, 329);
            this.buttonRemoveRow.Name = "buttonRemoveRow";
            this.buttonRemoveRow.Size = new System.Drawing.Size(216, 68);
            this.buttonRemoveRow.TabIndex = 4;
            this.buttonRemoveRow.Text = "Usuń wybraną wizytę";
            this.buttonRemoveRow.UseVisualStyleBackColor = true;
            this.buttonRemoveRow.Click += new System.EventHandler(this.buttonRemoveRow_Click);
            // 
            // buttonAddNewRow
            // 
            this.buttonAddNewRow.Location = new System.Drawing.Point(319, 329);
            this.buttonAddNewRow.Name = "buttonAddNewRow";
            this.buttonAddNewRow.Size = new System.Drawing.Size(233, 68);
            this.buttonAddNewRow.TabIndex = 5;
            this.buttonAddNewRow.Text = "Dodaj nową wizytę";
            this.buttonAddNewRow.UseVisualStyleBackColor = true;
            this.buttonAddNewRow.Click += new System.EventHandler(this.buttonAddNewRow_Click);
            // 
            // buttonPsychiatra
            // 
            this.buttonPsychiatra.Location = new System.Drawing.Point(884, 145);
            this.buttonPsychiatra.Name = "buttonPsychiatra";
            this.buttonPsychiatra.Size = new System.Drawing.Size(200, 71);
            this.buttonPsychiatra.TabIndex = 6;
            this.buttonPsychiatra.Text = "Filtrowanie Psychiatra";
            this.buttonPsychiatra.UseVisualStyleBackColor = true;
            this.buttonPsychiatra.Click += new System.EventHandler(this.buttonPsychiatra_Click);
            // 
            // buttonGinekolog
            // 
            this.buttonGinekolog.Location = new System.Drawing.Point(884, 241);
            this.buttonGinekolog.Name = "buttonGinekolog";
            this.buttonGinekolog.Size = new System.Drawing.Size(200, 71);
            this.buttonGinekolog.TabIndex = 7;
            this.buttonGinekolog.Text = "Filtrowanie Ginekolog";
            this.buttonGinekolog.UseVisualStyleBackColor = true;
            this.buttonGinekolog.Click += new System.EventHandler(this.buttonGinekolog_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(621, 329);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(233, 68);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Odśwież listę";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonShowDoctors
            // 
            this.buttonShowDoctors.Location = new System.Drawing.Point(884, 329);
            this.buttonShowDoctors.Name = "buttonShowDoctors";
            this.buttonShowDoctors.Size = new System.Drawing.Size(200, 68);
            this.buttonShowDoctors.TabIndex = 9;
            this.buttonShowDoctors.Text = "Pokaż dostępnych lekarzy";
            this.buttonShowDoctors.UseVisualStyleBackColor = true;
            this.buttonShowDoctors.Click += new System.EventHandler(this.buttonShowDoctors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Witamy w przychodni KREDEK-MED";
            // 
            // FormHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowDoctors);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonGinekolog);
            this.Controls.Add(this.buttonPsychiatra);
            this.Controls.Add(this.buttonAddNewRow);
            this.Controls.Add(this.buttonRemoveRow);
            this.Controls.Add(this.buttonOkulista);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Name = "FormHospital";
            this.Text = "Przychodnia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.Button buttonOkulista;
        private System.Windows.Forms.Button buttonRemoveRow;
        private System.Windows.Forms.Button buttonAddNewRow;
        private System.Windows.Forms.Button buttonPsychiatra;
        private System.Windows.Forms.Button buttonGinekolog;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonShowDoctors;
        private System.Windows.Forms.Label label1;
    }
}