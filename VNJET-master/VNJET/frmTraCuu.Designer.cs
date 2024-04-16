namespace VNJET
{
    partial class frmTraCuu
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
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayKHTu = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKHDen = new System.Windows.Forms.DateTimePicker();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.lbBanVe = new System.Windows.Forms.Label();
            this.btnChonChuyenBay = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxDSChyenBay = new System.Windows.Forms.GroupBox();
            this.dtgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.gbxTTChuyenBay = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.gbxThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDSChyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).BeginInit();
            this.gbxTTChuyenBay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 139);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 87;
            this.label15.Text = "Ngày khởi hành từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Ngày đến";
            // 
            // dtpNgayKHTu
            // 
            this.dtpNgayKHTu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKHTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKHTu.Location = new System.Drawing.Point(173, 134);
            this.dtpNgayKHTu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayKHTu.Name = "dtpNgayKHTu";
            this.dtpNgayKHTu.Size = new System.Drawing.Size(199, 22);
            this.dtpNgayKHTu.TabIndex = 3;
            // 
            // dtpNgayKHDen
            // 
            this.dtpNgayKHDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKHDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKHDen.Location = new System.Drawing.Point(173, 169);
            this.dtpNgayKHDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayKHDen.Name = "dtpNgayKHDen";
            this.dtpNgayKHDen.Size = new System.Drawing.Size(199, 22);
            this.dtpNgayKHDen.TabIndex = 4;
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.lbBanVe);
            this.gbxThaoTac.Controls.Add(this.btnChonChuyenBay);
            this.gbxThaoTac.Controls.Add(this.lbTimKiem);
            this.gbxThaoTac.Controls.Add(this.btnTimKiem);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 565);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 2;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // lbBanVe
            // 
            this.lbBanVe.AutoSize = true;
            this.lbBanVe.Location = new System.Drawing.Point(205, 78);
            this.lbBanVe.Name = "lbBanVe";
            this.lbBanVe.Size = new System.Drawing.Size(110, 16);
            this.lbBanVe.TabIndex = 93;
            this.lbBanVe.Text = "Chọn chuyến bay";
            // 
            // btnChonChuyenBay
            // 
            this.btnChonChuyenBay.BackgroundImage = global::VNJET.Properties.Resources.btnMua;
            this.btnChonChuyenBay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonChuyenBay.Location = new System.Drawing.Point(229, 22);
            this.btnChonChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChonChuyenBay.Name = "btnChonChuyenBay";
            this.btnChonChuyenBay.Size = new System.Drawing.Size(55, 50);
            this.btnChonChuyenBay.TabIndex = 6;
            this.btnChonChuyenBay.UseVisualStyleBackColor = true;
            this.btnChonChuyenBay.Click += new System.EventHandler(this.btnChonChuyenBay_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(91, 78);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(62, 16);
            this.lbTimKiem.TabIndex = 91;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::VNJET.Properties.Resources.btnTimKiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(95, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(55, 50);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 58);
            this.panel1.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::VNJET.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1205, 4);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 50);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxDSChyenBay
            // 
            this.gbxDSChyenBay.Controls.Add(this.dtgvChuyenBay);
            this.gbxDSChyenBay.Location = new System.Drawing.Point(397, 64);
            this.gbxDSChyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChyenBay.Name = "gbxDSChyenBay";
            this.gbxDSChyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSChyenBay.Size = new System.Drawing.Size(853, 602);
            this.gbxDSChyenBay.TabIndex = 3;
            this.gbxDSChyenBay.TabStop = false;
            this.gbxDSChyenBay.Text = "Danh sách chuyến bay";
            // 
            // dtgvChuyenBay
            // 
            this.dtgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay.Location = new System.Drawing.Point(5, 28);
            this.dtgvChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvChuyenBay.Name = "dtgvChuyenBay";
            this.dtgvChuyenBay.RowHeadersWidth = 82;
            this.dtgvChuyenBay.RowTemplate.Height = 24;
            this.dtgvChuyenBay.Size = new System.Drawing.Size(843, 569);
            this.dtgvChuyenBay.TabIndex = 7;
            this.dtgvChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenBay_CellClick);
            // 
            // gbxTTChuyenBay
            // 
            this.gbxTTChuyenBay.Controls.Add(this.label20);
            this.gbxTTChuyenBay.Controls.Add(this.label18);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDen);
            this.gbxTTChuyenBay.Controls.Add(this.label19);
            this.gbxTTChuyenBay.Controls.Add(this.dtpNgayKHDen);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDi);
            this.gbxTTChuyenBay.Controls.Add(this.dtpNgayKHTu);
            this.gbxTTChuyenBay.Controls.Add(this.txtMaChuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.label15);
            this.gbxTTChuyenBay.Controls.Add(this.label3);
            this.gbxTTChuyenBay.Location = new System.Drawing.Point(12, 64);
            this.gbxTTChuyenBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTChuyenBay.Name = "gbxTTChuyenBay";
            this.gbxTTChuyenBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTChuyenBay.Size = new System.Drawing.Size(380, 495);
            this.gbxTTChuyenBay.TabIndex = 1;
            this.gbxTTChuyenBay.TabStop = false;
            this.gbxTTChuyenBay.Text = "Thông tin chuyến bay";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 33);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã chuyến bay ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "Sân bay đến";
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(173, 95);
            this.cboSanBayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDen.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Sân bay đi";
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(173, 63);
            this.cboSanBayDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDi.TabIndex = 1;
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(173, 28);
            this.txtMaChuyenBay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(200, 22);
            this.txtMaChuyenBay.TabIndex = 17;
            this.txtMaChuyenBay.TabStop = false;
            // 
            // frmTraCuu
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1272, 697);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSChyenBay);
            this.Controls.Add(this.gbxTTChuyenBay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu chuyến bay";
            this.Shown += new System.EventHandler(this.frmTraCuu_Shown);
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSChyenBay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).EndInit();
            this.gbxTTChuyenBay.ResumeLayout(false);
            this.gbxTTChuyenBay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayKHTu;
        private System.Windows.Forms.DateTimePicker dtpNgayKHDen;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSChyenBay;
        private System.Windows.Forms.DataGridView dtgvChuyenBay;
        private System.Windows.Forms.GroupBox gbxTTChuyenBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Button btnChonChuyenBay;
        private System.Windows.Forms.Label lbBanVe;
    }
}