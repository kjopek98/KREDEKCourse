namespace KrzysztofJopekLab1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.changeButtonsColor = new System.Windows.Forms.Button();
            this.changeButtonsFont = new System.Windows.Forms.Button();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxCount2 = new System.Windows.Forms.TextBox();
            this.buttonCount2 = new System.Windows.Forms.Button();
            this.buttonCounterStart = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(197, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(375, 57);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Krzysztof Jopek";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(39, 222);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(126, 47);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Kolor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // changeButtonsColor
            // 
            this.changeButtonsColor.Location = new System.Drawing.Point(224, 222);
            this.changeButtonsColor.Name = "changeButtonsColor";
            this.changeButtonsColor.Size = new System.Drawing.Size(126, 47);
            this.changeButtonsColor.TabIndex = 2;
            this.changeButtonsColor.Text = "Zmień kolor przycisków";
            this.changeButtonsColor.UseVisualStyleBackColor = true;
            this.changeButtonsColor.Click += new System.EventHandler(this.changeButtonsColor_Click);
            // 
            // changeButtonsFont
            // 
            this.changeButtonsFont.Location = new System.Drawing.Point(411, 222);
            this.changeButtonsFont.Name = "changeButtonsFont";
            this.changeButtonsFont.Size = new System.Drawing.Size(126, 47);
            this.changeButtonsFont.TabIndex = 3;
            this.changeButtonsFont.Text = "Zmień czcionkę przycisków";
            this.changeButtonsFont.UseVisualStyleBackColor = true;
            this.changeButtonsFont.Click += new System.EventHandler(this.changeButtonsFont_Click);
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(609, 221);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(126, 48);
            this.buttonIndex.TabIndex = 4;
            this.buttonIndex.Text = "Numer indeksu";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.buttonIndex_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(39, 325);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(126, 22);
            this.textBoxCount.TabIndex = 5;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(39, 376);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(126, 23);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Policz";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxCount2
            // 
            this.textBoxCount2.Location = new System.Drawing.Point(224, 325);
            this.textBoxCount2.Name = "textBoxCount2";
            this.textBoxCount2.Size = new System.Drawing.Size(126, 22);
            this.textBoxCount2.TabIndex = 7;
            // 
            // buttonCount2
            // 
            this.buttonCount2.Location = new System.Drawing.Point(224, 376);
            this.buttonCount2.Name = "buttonCount2";
            this.buttonCount2.Size = new System.Drawing.Size(126, 23);
            this.buttonCount2.TabIndex = 8;
            this.buttonCount2.Text = "Licznik+1";
            this.buttonCount2.UseVisualStyleBackColor = true;
            this.buttonCount2.Click += new System.EventHandler(this.buttonCount2_Click);
            // 
            // buttonCounterStart
            // 
            this.buttonCounterStart.Location = new System.Drawing.Point(142, 415);
            this.buttonCounterStart.Name = "buttonCounterStart";
            this.buttonCounterStart.Size = new System.Drawing.Size(106, 23);
            this.buttonCounterStart.TabIndex = 9;
            this.buttonCounterStart.Text = "Suma";
            this.buttonCounterStart.UseVisualStyleBackColor = true;
            this.buttonCounterStart.Click += new System.EventHandler(this.buttonCounterStart_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.Location = new System.Drawing.Point(411, 376);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(109, 23);
            this.buttonTimerStart.TabIndex = 10;
            this.buttonTimerStart.Text = "Start Timera";
            this.buttonTimerStart.UseVisualStyleBackColor = true;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(609, 376);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(109, 24);
            this.buttonNewWindow.TabIndex = 11;
            this.buttonNewWindow.Text = "Nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonTimerStart);
            this.Controls.Add(this.buttonCounterStart);
            this.Controls.Add(this.buttonCount2);
            this.Controls.Add(this.textBoxCount2);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonIndex);
            this.Controls.Add(this.changeButtonsFont);
            this.Controls.Add(this.changeButtonsColor);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "buttonColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button changeButtonsColor;
        private System.Windows.Forms.Button changeButtonsFont;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxCount2;
        private System.Windows.Forms.Button buttonCount2;
        private System.Windows.Forms.Button buttonCounterStart;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

