namespace KrzysztofJopekLab3Zadanie
{
    partial class FormNewVisit
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
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVisit = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(45, 222);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(225, 77);
            this.buttonAddVisit.TabIndex = 0;
            this.buttonAddVisit.Text = "Zamów wizytę";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(12, 114);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(314, 24);
            this.comboBoxDoctors.TabIndex = 2;
            // 
            // dateTimePickerVisit
            // 
            this.dateTimePickerVisit.Location = new System.Drawing.Point(12, 185);
            this.dateTimePickerVisit.Name = "dateTimePickerVisit";
            this.dateTimePickerVisit.Size = new System.Drawing.Size(314, 22);
            this.dateTimePickerVisit.TabIndex = 3;
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.FormattingEnabled = true;
            this.comboBoxPatients.Location = new System.Drawing.Point(12, 58);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(314, 24);
            this.comboBoxPatients.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pacjent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lekarz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data wizyty:";
            // 
            // FormNewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPatients);
            this.Controls.Add(this.dateTimePickerVisit);
            this.Controls.Add(this.comboBoxDoctors);
            this.Controls.Add(this.buttonAddVisit);
            this.Name = "FormNewVisit";
            this.Text = "Zamów wizytę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisit;
        private System.Windows.Forms.ComboBox comboBoxPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}