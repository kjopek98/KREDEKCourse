namespace KrzysztofJopekLab4Zadanie
{
    partial class BuyTicket
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
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxTicketPlaceNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTicketFlightId = new System.Windows.Forms.TextBox();
            this.textBoxTicketPassengerId = new System.Windows.Forms.TextBox();
            this.buttonTicketAdd = new System.Windows.Forms.Button();
            this.textBoxTicketLuggageId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonTicketDelete = new System.Windows.Forms.Button();
            this.buttonTicketUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUpdateTicketPlaceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUpdateTicketFlightId = new System.Windows.Forms.TextBox();
            this.textBoxUpdateTicketPassengerId = new System.Windows.Forms.TextBox();
            this.buttonTicketSaveChanges = new System.Windows.Forms.Button();
            this.textBoxUpdateTicketLuggageId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateTicketId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(362, 42);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(477, 242);
            this.dataGridViewTickets.TabIndex = 49;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxTicketPlaceNumber);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.textBoxTicketFlightId);
            this.panel5.Controls.Add(this.textBoxTicketPassengerId);
            this.panel5.Controls.Add(this.buttonTicketAdd);
            this.panel5.Controls.Add(this.textBoxTicketLuggageId);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 297);
            this.panel5.TabIndex = 51;
            // 
            // textBoxTicketPlaceNumber
            // 
            this.textBoxTicketPlaceNumber.Location = new System.Drawing.Point(137, 29);
            this.textBoxTicketPlaceNumber.Name = "textBoxTicketPlaceNumber";
            this.textBoxTicketPlaceNumber.Size = new System.Drawing.Size(166, 22);
            this.textBoxTicketPlaceNumber.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Numer siedzenia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Id lotu";
            // 
            // textBoxTicketFlightId
            // 
            this.textBoxTicketFlightId.Location = new System.Drawing.Point(137, 173);
            this.textBoxTicketFlightId.Name = "textBoxTicketFlightId";
            this.textBoxTicketFlightId.Size = new System.Drawing.Size(166, 22);
            this.textBoxTicketFlightId.TabIndex = 18;
            // 
            // textBoxTicketPassengerId
            // 
            this.textBoxTicketPassengerId.Location = new System.Drawing.Point(137, 128);
            this.textBoxTicketPassengerId.Name = "textBoxTicketPassengerId";
            this.textBoxTicketPassengerId.Size = new System.Drawing.Size(166, 22);
            this.textBoxTicketPassengerId.TabIndex = 17;
            // 
            // buttonTicketAdd
            // 
            this.buttonTicketAdd.Location = new System.Drawing.Point(73, 239);
            this.buttonTicketAdd.Name = "buttonTicketAdd";
            this.buttonTicketAdd.Size = new System.Drawing.Size(176, 32);
            this.buttonTicketAdd.TabIndex = 16;
            this.buttonTicketAdd.Text = "Dodaj bilet";
            this.buttonTicketAdd.UseVisualStyleBackColor = true;
            this.buttonTicketAdd.Click += new System.EventHandler(this.buttonTicketAdd_Click);
            // 
            // textBoxTicketLuggageId
            // 
            this.textBoxTicketLuggageId.Location = new System.Drawing.Point(137, 80);
            this.textBoxTicketLuggageId.Name = "textBoxTicketLuggageId";
            this.textBoxTicketLuggageId.Size = new System.Drawing.Size(166, 22);
            this.textBoxTicketLuggageId.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Id pasażera";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Id bagażu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(513, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 29);
            this.label13.TabIndex = 53;
            this.label13.Text = "Wszystkie bilety";
            // 
            // buttonTicketDelete
            // 
            this.buttonTicketDelete.Location = new System.Drawing.Point(362, 291);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(236, 46);
            this.buttonTicketDelete.TabIndex = 54;
            this.buttonTicketDelete.Text = "Usuń bilet";
            this.buttonTicketDelete.UseVisualStyleBackColor = true;
            this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
            // 
            // buttonTicketUpdate
            // 
            this.buttonTicketUpdate.Location = new System.Drawing.Point(604, 291);
            this.buttonTicketUpdate.Name = "buttonTicketUpdate";
            this.buttonTicketUpdate.Size = new System.Drawing.Size(235, 47);
            this.buttonTicketUpdate.TabIndex = 55;
            this.buttonTicketUpdate.Text = "Edytuj bilet";
            this.buttonTicketUpdate.UseVisualStyleBackColor = true;
            this.buttonTicketUpdate.Click += new System.EventHandler(this.buttonTicketUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxUpdateTicketId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxUpdateTicketPlaceNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxUpdateTicketFlightId);
            this.panel1.Controls.Add(this.textBoxUpdateTicketPassengerId);
            this.panel1.Controls.Add(this.buttonTicketSaveChanges);
            this.panel1.Controls.Add(this.textBoxUpdateTicketLuggageId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(857, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 297);
            this.panel1.TabIndex = 52;
            // 
            // textBoxUpdateTicketPlaceNumber
            // 
            this.textBoxUpdateTicketPlaceNumber.Location = new System.Drawing.Point(137, 66);
            this.textBoxUpdateTicketPlaceNumber.Name = "textBoxUpdateTicketPlaceNumber";
            this.textBoxUpdateTicketPlaceNumber.Size = new System.Drawing.Size(166, 22);
            this.textBoxUpdateTicketPlaceNumber.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numer siedzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id lotu";
            // 
            // textBoxUpdateTicketFlightId
            // 
            this.textBoxUpdateTicketFlightId.Location = new System.Drawing.Point(137, 193);
            this.textBoxUpdateTicketFlightId.Name = "textBoxUpdateTicketFlightId";
            this.textBoxUpdateTicketFlightId.Size = new System.Drawing.Size(166, 22);
            this.textBoxUpdateTicketFlightId.TabIndex = 18;
            // 
            // textBoxUpdateTicketPassengerId
            // 
            this.textBoxUpdateTicketPassengerId.Location = new System.Drawing.Point(137, 150);
            this.textBoxUpdateTicketPassengerId.Name = "textBoxUpdateTicketPassengerId";
            this.textBoxUpdateTicketPassengerId.Size = new System.Drawing.Size(166, 22);
            this.textBoxUpdateTicketPassengerId.TabIndex = 17;
            // 
            // buttonTicketSaveChanges
            // 
            this.buttonTicketSaveChanges.Location = new System.Drawing.Point(73, 239);
            this.buttonTicketSaveChanges.Name = "buttonTicketSaveChanges";
            this.buttonTicketSaveChanges.Size = new System.Drawing.Size(176, 32);
            this.buttonTicketSaveChanges.TabIndex = 16;
            this.buttonTicketSaveChanges.Text = "Zapisz zmiany";
            this.buttonTicketSaveChanges.UseVisualStyleBackColor = true;
            this.buttonTicketSaveChanges.Click += new System.EventHandler(this.buttonTicketSaveChanges_Click);
            // 
            // textBoxUpdateTicketLuggageId
            // 
            this.textBoxUpdateTicketLuggageId.Location = new System.Drawing.Point(137, 109);
            this.textBoxUpdateTicketLuggageId.Name = "textBoxUpdateTicketLuggageId";
            this.textBoxUpdateTicketLuggageId.Size = new System.Drawing.Size(166, 22);
            this.textBoxUpdateTicketLuggageId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id pasażera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id bagażu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id";
            // 
            // textBoxUpdateTicketId
            // 
            this.textBoxUpdateTicketId.Location = new System.Drawing.Point(137, 27);
            this.textBoxUpdateTicketId.Name = "textBoxUpdateTicketId";
            this.textBoxUpdateTicketId.Size = new System.Drawing.Size(166, 22);
            this.textBoxUpdateTicketId.TabIndex = 23;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTicketUpdate);
            this.Controls.Add(this.buttonTicketDelete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxTicketPlaceNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTicketFlightId;
        private System.Windows.Forms.TextBox textBoxTicketPassengerId;
        private System.Windows.Forms.Button buttonTicketAdd;
        private System.Windows.Forms.TextBox textBoxTicketLuggageId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonTicketDelete;
        private System.Windows.Forms.Button buttonTicketUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUpdateTicketId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateTicketPlaceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUpdateTicketFlightId;
        private System.Windows.Forms.TextBox textBoxUpdateTicketPassengerId;
        private System.Windows.Forms.Button buttonTicketSaveChanges;
        private System.Windows.Forms.TextBox textBoxUpdateTicketLuggageId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}