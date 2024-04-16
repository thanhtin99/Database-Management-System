using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNJET
{
    public partial class frmTraCuu : Form
    {
        ComboBox cboMaChuyenBay;
        FlightBUS flightBUS = new FlightBUS();
        AirportBUS airportBUS = new AirportBUS();
        public frmTraCuu()
        {
            InitializeComponent();
        }
        public frmTraCuu(ComboBox cboMaChuyenBay)
        {
            InitializeComponent();
            this.cboMaChuyenBay = cboMaChuyenBay;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (cboMaChuyenBay == null)
                this.Parent.Dispose();
            else
                this.Close();
        }

        private void frmTraCuu_Shown(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            cboSanBayDi.DataSource = airportBUS.GetForDisplay();
            cboSanBayDi.DisplayMember = "nameAirport";
            cboSanBayDi.ValueMember = "idAirport";

            cboSanBayDen.DataSource = airportBUS.GetForDisplay();
            cboSanBayDen.DisplayMember = "nameAirport";
            cboSanBayDen.ValueMember = "idAirport";

            if (cboMaChuyenBay == null)
            {
                btnChonChuyenBay.Visible = false;
                lbBanVe.Visible = false;
                btnTimKiem.Location = new Point(125, 22);
                lbTimKiem.Location = new Point(123, 65);
            }
            cboSanBayDi.Focus();
        }
        private void LoadDTGVFlight(string maSanBayDi, string maSanBayDen, DateTime thoiGianKHTu, DateTime thoiGianKHDen)
        {
            dtgvChuyenBay.DataSource = flightBUS.GetFlightByAirportAndTime(maSanBayDi, maSanBayDen, thoiGianKHTu, thoiGianKHDen);
            dtgvChuyenBay.Columns[0].HeaderText = "Mã chuyến bay";
            dtgvChuyenBay.Columns[1].HeaderText = "Thời gian khởi hành";
            dtgvChuyenBay.Columns[2].HeaderText = "Thời gian hạ cánh";
            dtgvChuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells[0].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboSanBayDi.Text != "" && cboSanBayDen.Text != "" && dtpNgayKHTu.Text != "" && dtpNgayKHDen.Text != "")
            {
                string maSanBayDi = cboSanBayDi.SelectedValue.ToString();
                string maSanBayDen = cboSanBayDen.SelectedValue.ToString();
                DateTime ngayKHTu = dtpNgayKHTu.Value;
                DateTime ngayKHDen = dtpNgayKHDen.Value;
                LoadDTGVFlight(maSanBayDi, maSanBayDen, ngayKHTu, ngayKHDen);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChonChuyenBay_Click(object sender, EventArgs e)
        {
            cboMaChuyenBay.Text = txtMaChuyenBay.Text;
            this.Close();
        }
    }
}
