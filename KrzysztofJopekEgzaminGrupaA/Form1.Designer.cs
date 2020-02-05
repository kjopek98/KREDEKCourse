namespace KrzysztofJopekEgzaminGrupaA
{
    partial class Logowanie
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
            this.components = new System.ComponentModel.Container();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonA1Zaloguj = new System.Windows.Forms.Button();
            this.buttonA2Start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonA3Pracownicy = new System.Windows.Forms.Button();
            this.dataGridViewNorthwind = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonA5Produkty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthwind)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(167, 39);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(180, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 101);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło";
            // 
            // buttonA1Zaloguj
            // 
            this.buttonA1Zaloguj.Location = new System.Drawing.Point(128, 144);
            this.buttonA1Zaloguj.Name = "buttonA1Zaloguj";
            this.buttonA1Zaloguj.Size = new System.Drawing.Size(112, 36);
            this.buttonA1Zaloguj.TabIndex = 4;
            this.buttonA1Zaloguj.Text = "A1 Zaloguj";
            this.buttonA1Zaloguj.UseVisualStyleBackColor = true;
            this.buttonA1Zaloguj.Click += new System.EventHandler(this.buttonA1Zaloguj_Click);
            // 
            // buttonA2Start
            // 
            this.buttonA2Start.Location = new System.Drawing.Point(128, 196);
            this.buttonA2Start.Name = "buttonA2Start";
            this.buttonA2Start.Size = new System.Drawing.Size(112, 38);
            this.buttonA2Start.TabIndex = 5;
            this.buttonA2Start.Text = "A2 Start";
            this.buttonA2Start.UseVisualStyleBackColor = true;
            this.buttonA2Start.Click += new System.EventHandler(this.buttonA2Start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonA3Pracownicy
            // 
            this.buttonA3Pracownicy.Location = new System.Drawing.Point(128, 240);
            this.buttonA3Pracownicy.Name = "buttonA3Pracownicy";
            this.buttonA3Pracownicy.Size = new System.Drawing.Size(112, 34);
            this.buttonA3Pracownicy.TabIndex = 6;
            this.buttonA3Pracownicy.Text = "A3 Pracownicy";
            this.buttonA3Pracownicy.UseVisualStyleBackColor = true;
            this.buttonA3Pracownicy.Click += new System.EventHandler(this.buttonA3Pracownicy_Click);
            // 
            // dataGridViewNorthwind
            // 
            this.dataGridViewNorthwind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNorthwind.Location = new System.Drawing.Point(422, 30);
            this.dataGridViewNorthwind.Name = "dataGridViewNorthwind";
            this.dataGridViewNorthwind.RowHeadersWidth = 51;
            this.dataGridViewNorthwind.RowTemplate.Height = 24;
            this.dataGridViewNorthwind.Size = new System.Drawing.Size(506, 169);
            this.dataGridViewNorthwind.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 196);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 17);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // buttonA5Produkty
            // 
            this.buttonA5Produkty.Location = new System.Drawing.Point(128, 294);
            this.buttonA5Produkty.Name = "buttonA5Produkty";
            this.buttonA5Produkty.Size = new System.Drawing.Size(112, 33);
            this.buttonA5Produkty.TabIndex = 9;
            this.buttonA5Produkty.Text = "A5 Produkty";
            this.buttonA5Produkty.UseVisualStyleBackColor = true;
            this.buttonA5Produkty.Click += new System.EventHandler(this.buttonA5Produkty_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 374);
            this.Controls.Add(this.buttonA5Produkty);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dataGridViewNorthwind);
            this.Controls.Add(this.buttonA3Pracownicy);
            this.Controls.Add(this.buttonA2Start);
            this.Controls.Add(this.buttonA1Zaloguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthwind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonA1Zaloguj;
        private System.Windows.Forms.Button buttonA2Start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonA3Pracownicy;
        private System.Windows.Forms.DataGridView dataGridViewNorthwind;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonA5Produkty;
    }
}

