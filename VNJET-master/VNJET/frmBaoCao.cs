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
    public partial class frmBaoCao : Form
    {
        StaffBUS staffbus = new StaffBUS();
        SaleBUS salebus = new SaleBUS();
        DateTime now = DateTime.Now;
        public frmBaoCao()
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
            DataTable dtCB = staffbus.GetForDisplay();
            cboIDStaff.DataSource = dtCB;
            cboIDStaff.DisplayMember = "idStaffs";
            cboIDStaff.ValueMember = "idStaffs";

            LoadDTGVReportByTime();
            LoadDTGVReportByStaff();

            txtMonth.Text = now.Month.ToString();
            txtYear.Text = now.Year.ToString();

            txtMonth.Focus();
        }

        private void LoadDTGVReportByTime()
        {
            DataTable dtrpbytime = salebus.GetForDisplayByTime();
            dtgvReport1.DataSource = dtrpbytime;
            dtgvReport1.Columns[0].HeaderText = "Tháng";
            dtgvReport1.Columns[1].HeaderText = "Năm";
            dtgvReport1.Columns[2].HeaderText = "Mã chuyến bay";
            dtgvReport1.Columns[3].HeaderText = "Số vé đã bán";
            dtgvReport1.Columns[4].HeaderText = "Tổng tiền";
            dtgvReport1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvReport1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

       
        private void LoadDTGVReportByStaff()
        {
            DataTable dtrpbystaff = salebus.GetForDisplayByStaff();
            dtgvReport2.DataSource = dtrpbystaff;
            dtgvReport2.Columns[0].HeaderText = "Mã nhân viên";
            dtgvReport2.Columns[1].HeaderText = "Tên nhân viên";
            dtgvReport2.Columns[2].HeaderText = "SĐT";
            dtgvReport2.Columns[3].HeaderText = "Số vé đã bán";
            dtgvReport2.Columns[4].HeaderText = "Tổng tiền";
            dtgvReport2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvReport2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvReport1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvReport1.Rows[e.RowIndex];
            txtMonth.Text = row.Cells[0].Value.ToString();
            txtYear.Text = row.Cells[1].Value.ToString();
        }


        private void dtgvReport2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvReport2.Rows[e.RowIndex];
            cboIDStaff.SelectedValue = row.Cells[0].Value.ToString();
        }

        private void btnViewRP1_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text != "" && txtYear.Text != "")
            {
                int month = Convert.ToInt32(txtMonth.Text);
                int year = Convert.ToInt32(txtYear.Text);
                dtgvReport1.DataSource = salebus.SaleByTime(month, year);
            }
            else
                dtgvReport1.DataSource = salebus.GetForDisplayByTime();
        }

        private void btnViewRP2_Click(object sender, EventArgs e)
        {
            if (cboIDStaff.Text != "")
                dtgvReport2.DataSource = salebus.SaleByIDStaff(cboIDStaff.SelectedValue.ToString());
            else
                dtgvReport2.DataSource = salebus.GetForDisplayByStaff();
        }

        private void txtMonth_Leave(object sender, EventArgs e)
        {
            try
            {
                int month = Convert.ToInt32(txtMonth.Text);
                if (month < 1 || month > 12)
                {
                    txtMonth.Text = now.Month.ToString();
                    MessageBox.Show("Vui lòng nhập đúng tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }
    }
}
