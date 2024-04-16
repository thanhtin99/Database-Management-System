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
    public partial class frmQuanLyKhachHang : Form
    {
        CustomerBUS cusbus = new CustomerBUS();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            LoadForm();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void LoadForm()
        {
            LoadDTGVCustomer();
            txtTenKhachHang.Focus();
        }
        private void LoadDTGVCustomer()
        {
            DataTable dtKhachHang = cusbus.GetForDisplay();
            dtgvKhachHang.DataSource = dtKhachHang;
            dtgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dtgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dtgvKhachHang.Columns[2].HeaderText = "CMND";
            dtgvKhachHang.Columns[3].HeaderText = "SĐT";
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
            txtMaKhachHang.Text = row.Cells[0].Value.ToString();
            txtTenKhachHang.Text = row.Cells[1].Value.ToString();
            txtCMND.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
        }
    }
}
