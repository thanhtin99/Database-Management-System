using BUS;
using DTO;
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
    public partial class frmQuanLySanBay : Form
    {
        AirportBUS airportbus = new AirportBUS();
        public frmQuanLySanBay()
        {
            InitializeComponent();
            LoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void Recreate()
        {
            LoadDTGVAirport();
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtTenThanhPho.Clear();
            txtTenSanBay.Focus();
        }

        private void LoadForm()
        {
            LoadDTGVAirport();
            txtTenSanBay.Focus();
        }
        private void LoadDTGVAirport()
        {
            DataTable dtSanBay = airportbus.GetForDisplay();
            dtgvSanBay.DataSource = dtSanBay;
            dtgvSanBay.Columns[0].HeaderText = "Mã sân bay";
            dtgvSanBay.Columns[1].HeaderText = "Tên sân bay";
            dtgvSanBay.Columns[2].HeaderText = "Tên thành phố";
            dtgvSanBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvSanBay.Rows[e.RowIndex];
            txtMaSanBay.Text = row.Cells[0].Value.ToString();
            txtTenSanBay.Text = row.Cells[1].Value.ToString();
            txtTenThanhPho.Text = row.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
            {
                try
                {
                    AirportDTO dto = new AirportDTO(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                    if (airportbus.InsertAirport(dto))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Recreate();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() != "")
            {
                if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
                {
                    try
                    {
                        AirportDTO dto = new AirportDTO(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                        if (airportbus.UpdateAirport(dto))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Recreate();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() != "")
            {
                try
                {
                    string maSanBay = txtMaSanBay.Text;
                    if (airportbus.DeleteAirport(maSanBay))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Recreate();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvSanBay.DataSource = airportbus.SearchByName(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
