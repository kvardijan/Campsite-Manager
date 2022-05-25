namespace Campsite_Manager
{
    partial class FrmReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.cboHousing = new System.Windows.Forms.ComboBox();
            this.dtpReservationStart = new System.Windows.Forms.DateTimePicker();
            this.dtpReservationEnd = new System.Windows.Forms.DateTimePicker();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelReservationNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postavke rezervacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smještaj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Početak rezervacije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kraj rezervacije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kapacitet:";
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(191, 92);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(370, 22);
            this.txtGuest.TabIndex = 6;
            // 
            // cboHousing
            // 
            this.cboHousing.FormattingEnabled = true;
            this.cboHousing.Location = new System.Drawing.Point(191, 130);
            this.cboHousing.Name = "cboHousing";
            this.cboHousing.Size = new System.Drawing.Size(370, 24);
            this.cboHousing.TabIndex = 7;
            this.cboHousing.SelectedIndexChanged += new System.EventHandler(this.cboHousing_SelectedIndexChanged);
            // 
            // dtpReservationStart
            // 
            this.dtpReservationStart.Location = new System.Drawing.Point(191, 171);
            this.dtpReservationStart.Name = "dtpReservationStart";
            this.dtpReservationStart.Size = new System.Drawing.Size(370, 22);
            this.dtpReservationStart.TabIndex = 8;
            // 
            // dtpReservationEnd
            // 
            this.dtpReservationEnd.Location = new System.Drawing.Point(191, 213);
            this.dtpReservationEnd.Name = "dtpReservationEnd";
            this.dtpReservationEnd.Size = new System.Drawing.Size(370, 22);
            this.dtpReservationEnd.TabIndex = 9;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(191, 252);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(370, 22);
            this.numCapacity.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spremi promjene u bazu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 39);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelReservationNumber
            // 
            this.labelReservationNumber.AutoSize = true;
            this.labelReservationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationNumber.Location = new System.Drawing.Point(512, 13);
            this.labelReservationNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReservationNumber.Name = "labelReservationNumber";
            this.labelReservationNumber.Size = new System.Drawing.Size(49, 54);
            this.labelReservationNumber.TabIndex = 13;
            this.labelReservationNumber.Text = "#";
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 386);
            this.Controls.Add(this.labelReservationNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.dtpReservationEnd);
            this.Controls.Add(this.dtpReservationStart);
            this.Controls.Add(this.cboHousing);
            this.Controls.Add(this.txtGuest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservation";
            this.Text = "FrmReservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.ComboBox cboHousing;
        private System.Windows.Forms.DateTimePicker dtpReservationStart;
        private System.Windows.Forms.DateTimePicker dtpReservationEnd;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelReservationNumber;
    }
}