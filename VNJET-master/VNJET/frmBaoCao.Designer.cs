namespace VNJET
{
    partial class frmBaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnViewRP1 = new System.Windows.Forms.Button();
            this.gbxDSChuyenBay = new System.Windows.Forms.GroupBox();
            this.dtgvReport1 = new System.Windows.Forms.DataGridView();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvReport2 = new System.Windows.Forms.DataGridView();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewRP2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboIDStaff = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gbxDSChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 47);
            this.panel1.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "BÁO CÁO DOANH THU";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::VNJET.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(904, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 41);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnViewRP1
            // 
            this.btnViewRP1.AutoSize = true;
            this.btnViewRP1.Location = new System.Drawing.Point(347, 28);
            this.btnViewRP1.Name = "btnViewRP1";
            this.btnViewRP1.Size = new System.Drawing.Size(80, 23);
            this.btnViewRP1.TabIndex = 2;
            this.btnViewRP1.Text = "Xem báo cáo";
            this.btnViewRP1.UseVisualStyleBackColor = true;
            this.btnViewRP1.Click += new System.EventHandler(this.btnViewRP1_Click);
            // 
            // gbxDSChuyenBay
            // 
            this.gbxDSChuyenBay.Controls.Add(this.label2);
            this.gbxDSChuyenBay.Controls.Add(this.label1);
            this.gbxDSChuyenBay.Controls.Add(this.txtMonth);
            this.gbxDSChuyenBay.Controls.Add(this.dtgvReport1);
            this.gbxDSChuyenBay.Controls.Add(this.txtYear);
            this.gbxDSChuyenBay.Controls.Add(this.btnViewRP1);
            this.gbxDSChuyenBay.Location = new System.Drawing.Point(10, 55);
            this.gbxDSChuyenBay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxDSChuyenBay.Name = "gbxDSChuyenBay";
            this.gbxDSChuyenBay.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxDSChuyenBay.Size = new System.Drawing.Size(460, 475);
            this.gbxDSChuyenBay.TabIndex = 132;
            this.gbxDSChuyenBay.TabStop = false;
            this.gbxDSChuyenBay.Text = "Doanh thu theo chuyến bay";
            // 
            // dtgvReport1
            // 
            this.dtgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport1.Location = new System.Drawing.Point(10, 65);
            this.dtgvReport1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvReport1.Name = "dtgvReport1";
            this.dtgvReport1.RowHeadersWidth = 82;
            this.dtgvReport1.RowTemplate.Height = 24;
            this.dtgvReport1.Size = new System.Drawing.Size(440, 400);
            this.dtgvReport1.TabIndex = 47;
            this.dtgvReport1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReport1_CellClick);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(221, 30);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(92, 20);
            this.txtYear.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboIDStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnViewRP2);
            this.groupBox1.Controls.Add(this.dtgvReport2);
            this.groupBox1.Location = new System.Drawing.Point(480, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(460, 475);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu theo nhân viên";
            // 
            // dtgvReport2
            // 
            this.dtgvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport2.Location = new System.Drawing.Point(10, 65);
            this.dtgvReport2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvReport2.Name = "dtgvReport2";
            this.dtgvReport2.RowHeadersWidth = 82;
            this.dtgvReport2.RowTemplate.Height = 24;
            this.dtgvReport2.Size = new System.Drawing.Size(440, 400);
            this.dtgvReport2.TabIndex = 47;
            this.dtgvReport2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReport2_CellClick);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(89, 30);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(92, 20);
            this.txtMonth.TabIndex = 0;
            this.txtMonth.Leave += new System.EventHandler(this.txtMonth_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Năm";
            // 
            // btnViewRP2
            // 
            this.btnViewRP2.AutoSize = true;
            this.btnViewRP2.Location = new System.Drawing.Point(318, 29);
            this.btnViewRP2.Name = "btnViewRP2";
            this.btnViewRP2.Size = new System.Drawing.Size(80, 23);
            this.btnViewRP2.TabIndex = 4;
            this.btnViewRP2.Text = "Xem báo cáo";
            this.btnViewRP2.UseVisualStyleBackColor = true;
            this.btnViewRP2.Click += new System.EventHandler(this.btnViewRP2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Mã nhân viên";
            // 
            // cboIDStaff
            // 
            this.cboIDStaff.FormattingEnabled = true;
            this.cboIDStaff.Location = new System.Drawing.Point(146, 31);
            this.cboIDStaff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboIDStaff.Name = "cboIDStaff";
            this.cboIDStaff.Size = new System.Drawing.Size(164, 21);
            this.cboIDStaff.TabIndex = 3;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDSChuyenBay);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo năm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSChuyenBay.ResumeLayout(false);
            this.gbxDSChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnViewRP1;
        private System.Windows.Forms.GroupBox gbxDSChuyenBay;
        private System.Windows.Forms.DataGridView dtgvReport1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvReport2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewRP2;
        private System.Windows.Forms.ComboBox cboIDStaff;
    }
}