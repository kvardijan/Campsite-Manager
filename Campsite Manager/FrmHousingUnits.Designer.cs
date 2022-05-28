namespace Campsite_Manager
{
    partial class FrmHousingUnits
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
            this.dgvHousingUnits = new System.Windows.Forms.DataGridView();
            this.btnEditReservation = new System.Windows.Forms.Button();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousingUnits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHousingUnits
            // 
            this.dgvHousingUnits.AllowUserToAddRows = false;
            this.dgvHousingUnits.AllowUserToDeleteRows = false;
            this.dgvHousingUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHousingUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHousingUnits.Location = new System.Drawing.Point(17, 16);
            this.dgvHousingUnits.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHousingUnits.Name = "dgvHousingUnits";
            this.dgvHousingUnits.ReadOnly = true;
            this.dgvHousingUnits.RowHeadersWidth = 51;
            this.dgvHousingUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHousingUnits.Size = new System.Drawing.Size(809, 383);
            this.dgvHousingUnits.TabIndex = 0;
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Location = new System.Drawing.Point(17, 433);
            this.btnEditReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(167, 43);
            this.btnEditReservation.TabIndex = 1;
            this.btnEditReservation.Text = "Uredi rezervaciju";
            this.btnEditReservation.UseVisualStyleBackColor = true;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Location = new System.Drawing.Point(192, 433);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(162, 43);
            this.btnNewReservation.TabIndex = 2;
            this.btnNewReservation.Text = "Nova rezervacija";
            this.btnNewReservation.UseVisualStyleBackColor = true;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(360, 433);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(162, 43);
            this.btnDeleteReservation.TabIndex = 3;
            this.btnDeleteReservation.Text = "Izbriši rezervaciju";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchBar);
            this.groupBox1.Location = new System.Drawing.Point(529, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje po imenu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(7, 19);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(284, 22);
            this.txtSearchBar.TabIndex = 0;
            this.txtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBar_KeyDown);
            // 
            // FrmHousingUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.dgvHousingUnits);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHousingUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campsite Manager";
            this.Load += new System.EventHandler(this.FrmHousingUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousingUnits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHousingUnits;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchBar;
    }
}

