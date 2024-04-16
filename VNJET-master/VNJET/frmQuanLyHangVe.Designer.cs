namespace VNJET
{
    partial class frmQuanLyHangVe
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
            this.txtMaHangVe = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTenHangVe = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxDSMayBay = new System.Windows.Forms.GroupBox();
            this.dtgvHangVe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxTTMayBay = new System.Windows.Forms.GroupBox();
            this.gbxThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDSMayBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).BeginInit();
            this.gbxTTMayBay.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaHangVe
            // 
            this.txtMaHangVe.Location = new System.Drawing.Point(141, 25);
            this.txtMaHangVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHangVe.Name = "txtMaHangVe";
            this.txtMaHangVe.ReadOnly = true;
            this.txtMaHangVe.Size = new System.Drawing.Size(232, 22);
            this.txtMaHangVe.TabIndex = 57;
            this.txtMaHangVe.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 28);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 55;
            this.label20.Text = "Mã hạng vé";
            // 
            // txtTenHangVe
            // 
            this.txtTenHangVe.Location = new System.Drawing.Point(141, 57);
            this.txtTenHangVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHangVe.Name = "txtTenHangVe";
            this.txtTenHangVe.Size = new System.Drawing.Size(232, 22);
            this.txtTenHangVe.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 56;
            this.label19.Text = "Tên hạng vé";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label4);
            this.gbxThaoTac.Controls.Add(this.label3);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 565);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 2;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::VNJET.Properties.Resources.btnThem;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(37, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.UseCompatibleTextRendering = true;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Xóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::VNJET.Properties.Resources.btnSua;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(167, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 50);
            this.btnSua.TabIndex = 3;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::VNJET.Properties.Resources.btnXoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(291, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 50);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 58);
            this.panel1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "QUẢN LÝ HẠNG VÉ";
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
            // gbxDSMayBay
            // 
            this.gbxDSMayBay.Controls.Add(this.dtgvHangVe);
            this.gbxDSMayBay.Controls.Add(this.label6);
            this.gbxDSMayBay.Controls.Add(this.txtTimKiem);
            this.gbxDSMayBay.Controls.Add(this.btnTimKiem);
            this.gbxDSMayBay.Location = new System.Drawing.Point(397, 64);
            this.gbxDSMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSMayBay.Name = "gbxDSMayBay";
            this.gbxDSMayBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDSMayBay.Size = new System.Drawing.Size(853, 602);
            this.gbxDSMayBay.TabIndex = 3;
            this.gbxDSMayBay.TabStop = false;
            this.gbxDSMayBay.Text = "Danh sách hạng vé";
            // 
            // dtgvHangVe
            // 
            this.dtgvHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangVe.Location = new System.Drawing.Point(5, 63);
            this.dtgvHangVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvHangVe.Name = "dtgvHangVe";
            this.dtgvHangVe.RowHeadersWidth = 82;
            this.dtgvHangVe.RowTemplate.Height = 24;
            this.dtgvHangVe.Size = new System.Drawing.Size(843, 533);
            this.dtgvHangVe.TabIndex = 7;
            this.dtgvHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangVe_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(641, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::VNJET.Properties.Resources.btnTimKiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(813, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(33, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxTTMayBay
            // 
            this.gbxTTMayBay.Controls.Add(this.txtMaHangVe);
            this.gbxTTMayBay.Controls.Add(this.label20);
            this.gbxTTMayBay.Controls.Add(this.txtTenHangVe);
            this.gbxTTMayBay.Controls.Add(this.label19);
            this.gbxTTMayBay.Location = new System.Drawing.Point(12, 64);
            this.gbxTTMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTMayBay.Name = "gbxTTMayBay";
            this.gbxTTMayBay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTTMayBay.Size = new System.Drawing.Size(380, 495);
            this.gbxTTMayBay.TabIndex = 1;
            this.gbxTTMayBay.TabStop = false;
            this.gbxTTMayBay.Text = "Thông tin hạng vé";
            // 
            // frmQuanLyHangVe
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1262, 678);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSMayBay);
            this.Controls.Add(this.gbxTTMayBay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLyHangVe";
            this.Text = "Thêm hạng vé";
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSMayBay.ResumeLayout(false);
            this.gbxDSMayBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).EndInit();
            this.gbxTTMayBay.ResumeLayout(false);
            this.gbxTTMayBay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaHangVe;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenHangVe;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSMayBay;
        private System.Windows.Forms.DataGridView dtgvHangVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTMayBay;
    }
}