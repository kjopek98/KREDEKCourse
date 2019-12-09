namespace KrzysztofJopekLab2ZadanieDomowe
{
    partial class Welcome
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(92, 146);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(144, 42);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Zatwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelEnterName
            // 
            this.labelEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnterName.Location = new System.Drawing.Point(63, 29);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(207, 31);
            this.labelEnterName.TabIndex = 1;
            this.labelEnterName.Text = "Wprowadź swoje imię";
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Location = new System.Drawing.Point(92, 84);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(144, 22);
            this.textBoxEnterName.TabIndex = 2;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 225);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.TextBox textBoxEnterName;
    }
}