namespace VNJET
{
    partial class frmMain
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
            this.mstrMain = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyChuyenBayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDonGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHangVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTuyenBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMayBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuChuyenBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnBanVe = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnTraCuuChuyenBay = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.mstrMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrMain
            // 
            this.mstrMain.BackColor = System.Drawing.Color.White;
            this.mstrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.thaoTacToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.baoCaoToolStripMenuItem});
            this.mstrMain.Location = new System.Drawing.Point(0, 0);
            this.mstrMain.Name = "mstrMain";
            this.mstrMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mstrMain.Size = new System.Drawing.Size(1277, 31);
            this.mstrMain.TabIndex = 2;
            this.mstrMain.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem1});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem1
            // 
            this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
            this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(173, 28);
            this.thoatToolStripMenuItem1.Text = "Thoát";
            this.thoatToolStripMenuItem1.Click += new System.EventHandler(this.thoatToolStripMenuItem1_Click);
            // 
            // thaoTacToolStripMenuItem
            // 
            this.thaoTacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banVeToolStripMenuItem,
            this.QuanLyThongTinToolStripMenuItem});
            this.thaoTacToolStripMenuItem.Name = "thaoTacToolStripMenuItem";
            this.thaoTacToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.thaoTacToolStripMenuItem.Text = "Thao tác";
            // 
            // banVeToolStripMenuItem
            // 
            this.banVeToolStripMenuItem.Name = "banVeToolStripMenuItem";
            this.banVeToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.banVeToolStripMenuItem.Text = "Bán vé";
            this.banVeToolStripMenuItem.Click += new System.EventHandler(this.banVeToolStripMenuItem_Click);
            // 
            // QuanLyThongTinToolStripMenuItem
            // 
            this.QuanLyThongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyChuyenBayToolStripMenuItem1,
            this.quanLyDonGiaToolStripMenuItem,
            this.quanLyHangVeToolStripMenuItem,
            this.quanLyTuyenBayToolStripMenuItem,
            this.quanLySanBayToolStripMenuItem,
            this.quanLyMayBayToolStripMenuItem,
            this.themNhanVienToolStripMenuItem,
            this.quanLyKhachHangToolStripMenuItem});
            this.QuanLyThongTinToolStripMenuItem.Name = "QuanLyThongTinToolStripMenuItem";
            this.QuanLyThongTinToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.QuanLyThongTinToolStripMenuItem.Text = "Quản lý thông tin";
            // 
            // quanLyChuyenBayToolStripMenuItem1
            // 
            this.quanLyChuyenBayToolStripMenuItem1.Name = "quanLyChuyenBayToolStripMenuItem1";
            this.quanLyChuyenBayToolStripMenuItem1.Size = new System.Drawing.Size(185, 28);
            this.quanLyChuyenBayToolStripMenuItem1.Text = "Chuyến bay";
            this.quanLyChuyenBayToolStripMenuItem1.Click += new System.EventHandler(this.quanLyChuyenBayToolStripMenuItem1_Click);
            // 
            // quanLyDonGiaToolStripMenuItem
            // 
            this.quanLyDonGiaToolStripMenuItem.Name = "quanLyDonGiaToolStripMenuItem";
            this.quanLyDonGiaToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLyDonGiaToolStripMenuItem.Text = "Đơn giá";
            this.quanLyDonGiaToolStripMenuItem.Click += new System.EventHandler(this.quanLyDonGiaToolStripMenuItem_Click);
            // 
            // quanLyHangVeToolStripMenuItem
            // 
            this.quanLyHangVeToolStripMenuItem.Name = "quanLyHangVeToolStripMenuItem";
            this.quanLyHangVeToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLyHangVeToolStripMenuItem.Text = "Hạng vé";
            this.quanLyHangVeToolStripMenuItem.Click += new System.EventHandler(this.quanLyHangVeToolStripMenuItem_Click);
            // 
            // quanLyTuyenBayToolStripMenuItem
            // 
            this.quanLyTuyenBayToolStripMenuItem.Name = "quanLyTuyenBayToolStripMenuItem";
            this.quanLyTuyenBayToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLyTuyenBayToolStripMenuItem.Text = "Tuyến bay";
            this.quanLyTuyenBayToolStripMenuItem.Click += new System.EventHandler(this.quanLyTuyenBayToolStripMenuItem_Click);
            // 
            // quanLySanBayToolStripMenuItem
            // 
            this.quanLySanBayToolStripMenuItem.Name = "quanLySanBayToolStripMenuItem";
            this.quanLySanBayToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLySanBayToolStripMenuItem.Text = "Sân bay";
            this.quanLySanBayToolStripMenuItem.Click += new System.EventHandler(this.quanLySanBayToolStripMenuItem_Click);
            // 
            // quanLyMayBayToolStripMenuItem
            // 
            this.quanLyMayBayToolStripMenuItem.Name = "quanLyMayBayToolStripMenuItem";
            this.quanLyMayBayToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLyMayBayToolStripMenuItem.Text = "Máy bay";
            this.quanLyMayBayToolStripMenuItem.Click += new System.EventHandler(this.quanLyMayBayToolStripMenuItem_Click);
            // 
            // themNhanVienToolStripMenuItem
            // 
            this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
            this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.themNhanVienToolStripMenuItem.Text = "Nhân viên";
            this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
            // 
            // quanLyKhachHangToolStripMenuItem
            // 
            this.quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
            this.quanLyKhachHangToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.quanLyKhachHangToolStripMenuItem.Text = "Khách hàng";
            this.quanLyKhachHangToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhachHangToolStripMenuItem_Click);
            // 
            // traCuuToolStripMenuItem
            // 
            this.traCuuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCuuChuyenBayToolStripMenuItem});
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.traCuuToolStripMenuItem.Text = "Tra cứu";
            // 
            // traCuuChuyenBayToolStripMenuItem
            // 
            this.traCuuChuyenBayToolStripMenuItem.Name = "traCuuChuyenBayToolStripMenuItem";
            this.traCuuChuyenBayToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.traCuuChuyenBayToolStripMenuItem.Text = "Chuyến bay";
            this.traCuuChuyenBayToolStripMenuItem.Click += new System.EventHandler(this.traCuuChuyenBayToolStripMenuItem_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.baoCaoToolStripMenuItem.Text = "Báo cáo";
            this.baoCaoToolStripMenuItem.Click += new System.EventHandler(this.baoCaoToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBanVe,
            this.toolStripBtnTraCuuChuyenBay,
            this.toolStripBtnDangXuat});
            this.toolStripMain.Location = new System.Drawing.Point(0, 31);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMain.Size = new System.Drawing.Size(1277, 97);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripBtnBanVe
            // 
            this.toolStripBtnBanVe.AutoSize = false;
            this.toolStripBtnBanVe.Image = global::VNJET.Properties.Resources.toolBanVe;
            this.toolStripBtnBanVe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBanVe.Name = "toolStripBtnBanVe";
            this.toolStripBtnBanVe.Size = new System.Drawing.Size(120, 94);
            this.toolStripBtnBanVe.Text = "Bán vé";
            this.toolStripBtnBanVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnBanVe.Click += new System.EventHandler(this.toolStripBtnBanVe_Click);
            // 
            // toolStripBtnTraCuuChuyenBay
            // 
            this.toolStripBtnTraCuuChuyenBay.AutoSize = false;
            this.toolStripBtnTraCuuChuyenBay.Image = global::VNJET.Properties.Resources.toolTraCuuChuyenBay;
            this.toolStripBtnTraCuuChuyenBay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTraCuuChuyenBay.Name = "toolStripBtnTraCuuChuyenBay";
            this.toolStripBtnTraCuuChuyenBay.Size = new System.Drawing.Size(120, 94);
            this.toolStripBtnTraCuuChuyenBay.Text = "Tra cứu chuyến bay";
            this.toolStripBtnTraCuuChuyenBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnTraCuuChuyenBay.Click += new System.EventHandler(this.toolStripBtnTraCuuChuyenBay_Click);
            // 
            // toolStripBtnDangXuat
            // 
            this.toolStripBtnDangXuat.AutoSize = false;
            this.toolStripBtnDangXuat.Image = global::VNJET.Properties.Resources.toolDangXuat;
            this.toolStripBtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDangXuat.Name = "toolStripBtnDangXuat";
            this.toolStripBtnDangXuat.Size = new System.Drawing.Size(120, 94);
            this.toolStripBtnDangXuat.Text = "Đăng xuất";
            this.toolStripBtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnDangXuat.Click += new System.EventHandler(this.toolStripBtnDangXuat_Click);
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 122);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1275, 700);
            this.tabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrlMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbMaNhanVien);
            this.panel1.Location = new System.Drawing.Point(1054, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 85);
            this.panel1.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(3, 57);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(44, 16);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "label1";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Location = new System.Drawing.Point(3, 12);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(44, 16);
            this.lbMaNhanVien.TabIndex = 0;
            this.lbMaNhanVien.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 822);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.mstrMain);
            this.MainMenuStrip = this.mstrMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm bán vé máy bay";
            this.mstrMain.ResumeLayout(false);
            this.mstrMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrMain;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thaoTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTuyenBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuChuyenBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banVeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnBanVe;
        private System.Windows.Forms.ToolStripButton toolStripBtnTraCuuChuyenBay;
        private System.Windows.Forms.ToolStripMenuItem quanLySanBayToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem quanLyMayBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyChuyenBayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quanLyHangVeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDonGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbMaNhanVien;
    }
}