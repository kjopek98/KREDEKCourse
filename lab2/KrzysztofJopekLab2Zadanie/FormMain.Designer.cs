namespace KrzysztofJopekLab2Zadanie
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
            this.groupBoxNewVehicle = new System.Windows.Forms.GroupBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfVehicle = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYearOfProduction = new System.Windows.Forms.Label();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioButtonTram = new System.Windows.Forms.RadioButton();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.buttonPantographUp = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonPantographDown = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelActualNameOfVehicleDescription = new System.Windows.Forms.Label();
            this.labelActualYearOfProductionDescription = new System.Windows.Forms.Label();
            this.labelNameOfVehicle = new System.Windows.Forms.Label();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.labelActualVehicleDescription = new System.Windows.Forms.Label();
            this.labelActualNumberOfVehicleDescription = new System.Windows.Forms.Label();
            this.labelActualYearOfProduction = new System.Windows.Forms.Label();
            this.labelActualNumberOfVehicle = new System.Windows.Forms.Label();
            this.labelMyName = new System.Windows.Forms.Label();
            this.groupBoxNewVehicle.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewVehicle
            // 
            this.groupBoxNewVehicle.Controls.Add(this.buttonAddVehicle);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxName);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxYearOfProduction);
            this.groupBoxNewVehicle.Controls.Add(this.textBoxNumberOfVehicle);
            this.groupBoxNewVehicle.Controls.Add(this.labelName);
            this.groupBoxNewVehicle.Controls.Add(this.labelYearOfProduction);
            this.groupBoxNewVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonBus);
            this.groupBoxNewVehicle.Controls.Add(this.radioButtonTram);
            this.groupBoxNewVehicle.Location = new System.Drawing.Point(12, 109);
            this.groupBoxNewVehicle.Name = "groupBoxNewVehicle";
            this.groupBoxNewVehicle.Size = new System.Drawing.Size(389, 516);
            this.groupBoxNewVehicle.TabIndex = 0;
            this.groupBoxNewVehicle.TabStop = false;
            this.groupBoxNewVehicle.Text = "Utwórz nowy pojazd";
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.AutoSize = true;
            this.buttonAddVehicle.Location = new System.Drawing.Point(115, 327);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(137, 27);
            this.buttonAddVehicle.TabIndex = 8;
            this.buttonAddVehicle.Text = "Dodaj nowy pojazd";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(170, 270);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(170, 220);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearOfProduction.TabIndex = 6;
            // 
            // textBoxNumberOfVehicle
            // 
            this.textBoxNumberOfVehicle.Location = new System.Drawing.Point(170, 171);
            this.textBoxNumberOfVehicle.Name = "textBoxNumberOfVehicle";
            this.textBoxNumberOfVehicle.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfVehicle.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 270);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Model";
            // 
            // labelYearOfProduction
            // 
            this.labelYearOfProduction.AutoSize = true;
            this.labelYearOfProduction.Location = new System.Drawing.Point(52, 220);
            this.labelYearOfProduction.Name = "labelYearOfProduction";
            this.labelYearOfProduction.Size = new System.Drawing.Size(94, 17);
            this.labelYearOfProduction.TabIndex = 3;
            this.labelYearOfProduction.Text = "Rok produkcji";
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(69, 171);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(77, 17);
            this.labelVehicleNumber.TabIndex = 2;
            this.labelVehicleNumber.Text = "Nr pojazdu";
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(226, 70);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(81, 21);
            this.radioButtonBus.TabIndex = 1;
            this.radioButtonBus.Text = "Autobus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTram
            // 
            this.radioButtonTram.AutoSize = true;
            this.radioButtonTram.Checked = true;
            this.radioButtonTram.Location = new System.Drawing.Point(72, 70);
            this.radioButtonTram.Name = "radioButtonTram";
            this.radioButtonTram.Size = new System.Drawing.Size(82, 21);
            this.radioButtonTram.TabIndex = 0;
            this.radioButtonTram.TabStop = true;
            this.radioButtonTram.Text = "Tramwaj";
            this.radioButtonTram.UseVisualStyleBackColor = true;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonPantographUp);
            this.groupBoxList.Controls.Add(this.buttonRefuel);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPantographDown);
            this.groupBoxList.Controls.Add(this.buttonBell);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActualNameOfVehicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProductionDescription);
            this.groupBoxList.Controls.Add(this.labelNameOfVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualNumberOfVehicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProduction);
            this.groupBoxList.Controls.Add(this.labelActualNumberOfVehicle);
            this.groupBoxList.Location = new System.Drawing.Point(419, 109);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(424, 516);
            this.groupBoxList.TabIndex = 1;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Lista obiektów";
            // 
            // buttonPantographUp
            // 
            this.buttonPantographUp.AutoSize = true;
            this.buttonPantographUp.Location = new System.Drawing.Point(233, 459);
            this.buttonPantographUp.Name = "buttonPantographUp";
            this.buttonPantographUp.Size = new System.Drawing.Size(134, 27);
            this.buttonPantographUp.TabIndex = 14;
            this.buttonPantographUp.Text = "Podnieś pantograf";
            this.buttonPantographUp.UseVisualStyleBackColor = true;
            this.buttonPantographUp.Click += new System.EventHandler(this.buttonPantographUp_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.AutoSize = true;
            this.buttonRefuel.Location = new System.Drawing.Point(233, 403);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(119, 27);
            this.buttonRefuel.TabIndex = 13;
            this.buttonRefuel.Text = "Zatankuj pojazd";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.AutoSize = true;
            this.buttonStopVehicle.Location = new System.Drawing.Point(233, 349);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(126, 27);
            this.buttonStopVehicle.TabIndex = 12;
            this.buttonStopVehicle.Text = "Zatrzymaj pojazd";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.AutoSize = true;
            this.buttonStartVehicle.Location = new System.Drawing.Point(33, 349);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(115, 27);
            this.buttonStartVehicle.TabIndex = 11;
            this.buttonStartVehicle.Text = "Rusz pojazdem";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonPantographDown
            // 
            this.buttonPantographDown.AutoSize = true;
            this.buttonPantographDown.Location = new System.Drawing.Point(33, 459);
            this.buttonPantographDown.Name = "buttonPantographDown";
            this.buttonPantographDown.Size = new System.Drawing.Size(124, 27);
            this.buttonPantographDown.TabIndex = 10;
            this.buttonPantographDown.Text = "Opuść pantograf";
            this.buttonPantographDown.UseVisualStyleBackColor = true;
            this.buttonPantographDown.Click += new System.EventHandler(this.buttonPantographDown_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.AutoSize = true;
            this.buttonBell.Location = new System.Drawing.Point(33, 403);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(148, 27);
            this.buttonBell.TabIndex = 9;
            this.buttonBell.Text = "Zadzwoń dzwonkiem";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.AutoSize = true;
            this.buttonNext.Location = new System.Drawing.Point(233, 301);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(132, 27);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Następny element";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.Location = new System.Drawing.Point(33, 301);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(136, 27);
            this.buttonPrevious.TabIndex = 7;
            this.buttonPrevious.Text = "Poprzedni element";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelActualNameOfVehicleDescription
            // 
            this.labelActualNameOfVehicleDescription.AutoSize = true;
            this.labelActualNameOfVehicleDescription.Location = new System.Drawing.Point(287, 225);
            this.labelActualNameOfVehicleDescription.Name = "labelActualNameOfVehicleDescription";
            this.labelActualNameOfVehicleDescription.Size = new System.Drawing.Size(0, 17);
            this.labelActualNameOfVehicleDescription.TabIndex = 6;
            // 
            // labelActualYearOfProductionDescription
            // 
            this.labelActualYearOfProductionDescription.AutoSize = true;
            this.labelActualYearOfProductionDescription.Location = new System.Drawing.Point(287, 176);
            this.labelActualYearOfProductionDescription.Name = "labelActualYearOfProductionDescription";
            this.labelActualYearOfProductionDescription.Size = new System.Drawing.Size(0, 17);
            this.labelActualYearOfProductionDescription.TabIndex = 5;
            // 
            // labelNameOfVehicle
            // 
            this.labelNameOfVehicle.AutoSize = true;
            this.labelNameOfVehicle.Location = new System.Drawing.Point(142, 225);
            this.labelNameOfVehicle.Name = "labelNameOfVehicle";
            this.labelNameOfVehicle.Size = new System.Drawing.Size(50, 17);
            this.labelNameOfVehicle.TabIndex = 4;
            this.labelNameOfVehicle.Text = "Model:";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(84, 74);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(108, 17);
            this.labelActualVehicle.TabIndex = 4;
            this.labelActualVehicle.Text = "Aktualny pojazd";
            // 
            // labelActualVehicleDescription
            // 
            this.labelActualVehicleDescription.AutoSize = true;
            this.labelActualVehicleDescription.Location = new System.Drawing.Point(287, 70);
            this.labelActualVehicleDescription.Name = "labelActualVehicleDescription";
            this.labelActualVehicleDescription.Size = new System.Drawing.Size(0, 17);
            this.labelActualVehicleDescription.TabIndex = 3;
            // 
            // labelActualNumberOfVehicleDescription
            // 
            this.labelActualNumberOfVehicleDescription.AutoSize = true;
            this.labelActualNumberOfVehicleDescription.Location = new System.Drawing.Point(287, 128);
            this.labelActualNumberOfVehicleDescription.Name = "labelActualNumberOfVehicleDescription";
            this.labelActualNumberOfVehicleDescription.Size = new System.Drawing.Size(0, 17);
            this.labelActualNumberOfVehicleDescription.TabIndex = 2;
            // 
            // labelActualYearOfProduction
            // 
            this.labelActualYearOfProduction.AutoSize = true;
            this.labelActualYearOfProduction.Location = new System.Drawing.Point(94, 176);
            this.labelActualYearOfProduction.Name = "labelActualYearOfProduction";
            this.labelActualYearOfProduction.Size = new System.Drawing.Size(98, 17);
            this.labelActualYearOfProduction.TabIndex = 1;
            this.labelActualYearOfProduction.Text = "Rok produkcji:";
            // 
            // labelActualNumberOfVehicle
            // 
            this.labelActualNumberOfVehicle.AutoSize = true;
            this.labelActualNumberOfVehicle.Location = new System.Drawing.Point(84, 128);
            this.labelActualNumberOfVehicle.Name = "labelActualNumberOfVehicle";
            this.labelActualNumberOfVehicle.Size = new System.Drawing.Size(108, 17);
            this.labelActualNumberOfVehicle.TabIndex = 0;
            this.labelActualNumberOfVehicle.Text = "Numer pojazdu:";
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyName.Location = new System.Drawing.Point(285, 30);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(303, 44);
            this.labelMyName.TabIndex = 2;
            this.labelMyName.Text = "Krzysztof Jopek";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 637);
            this.Controls.Add(this.labelMyName);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxNewVehicle);
            this.Name = "FormMain";
            this.Text = "Krzysztof Jopek";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxNewVehicle.ResumeLayout(false);
            this.groupBoxNewVehicle.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewVehicle;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxNumberOfVehicle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYearOfProduction;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.RadioButton radioButtonTram;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.Label labelActualNameOfVehicleDescription;
        private System.Windows.Forms.Label labelActualYearOfProductionDescription;
        private System.Windows.Forms.Label labelNameOfVehicle;
        private System.Windows.Forms.Label labelActualVehicle;
        private System.Windows.Forms.Label labelActualVehicleDescription;
        private System.Windows.Forms.Label labelActualNumberOfVehicleDescription;
        private System.Windows.Forms.Label labelActualYearOfProduction;
        private System.Windows.Forms.Label labelActualNumberOfVehicle;
        private System.Windows.Forms.Button buttonPantographUp;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPantographDown;
        private System.Windows.Forms.Button buttonBell;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
    }
}

