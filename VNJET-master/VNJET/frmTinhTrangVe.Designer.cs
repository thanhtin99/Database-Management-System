namespace VNJET
{
    partial class frmTinhTrangVe
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
            this.dtgvTinhTrangVe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTinhTrangVe
            // 
            this.dtgvTinhTrangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTinhTrangVe.Location = new System.Drawing.Point(4, 66);
            this.dtgvTinhTrangVe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvTinhTrangVe.Name = "dtgvTinhTrangVe";
            this.dtgvTinhTrangVe.RowHeadersWidth = 82;
            this.dtgvTinhTrangVe.RowTemplate.Height = 24;
            this.dtgvTinhTrangVe.Size = new System.Drawing.Size(768, 350);
            this.dtgvTinhTrangVe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chuyến bay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "TÌNH TRẠNG VÉ";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(369, 25);
            this.cboMaChuyenBay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(114, 21);
            this.cboMaChuyenBay.TabIndex = 1;
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 47);
            this.panel2.TabIndex = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvTinhTrangVe);
            this.groupBox1.Controls.Add(this.cboMaChuyenBay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(776, 421);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ghế ngồi";
            // 
            // frmTinhTrangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmTinhTrangVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhTrangVe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTinhTrangVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}