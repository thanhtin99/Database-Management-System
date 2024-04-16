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
    public partial class frmQuanLyMayBay : Form
    {
        PlaneBUS planbus = new PlaneBUS();
        public frmQuanLyMayBay()
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
            LoadDTGVPlane();
            txtMaMayBay.Clear();
            txtTenMayBay.Clear();
            txtSoLuongGhe.Clear();
            txtTenMayBay.Focus();
        }

        private void LoadForm()
        {
            LoadDTGVPlane();
            txtTenMayBay.Focus();
        }
        private void LoadDTGVPlane()
        {
            DataTable dtTuyenBay = planbus.GetForDisplay();
            dtgvMayBay.DataSource = dtTuyenBay;
            dtgvMayBay.Columns[0].HeaderText = "Mã máy bay";
            dtgvMayBay.Columns[1].HeaderText = "Tên máy bay";
            dtgvMayBay.Columns[2].HeaderText = "Số lượng ghế";
            dtgvMayBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMayBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvMayBay.Rows[e.RowIndex];
            txtMaMayBay.Text = row.Cells[0].Value.ToString();
            txtTenMayBay.Text = row.Cells[1].Value.ToString();
            txtSoLuongGhe.Text = row.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMayBay.Text.Trim() != "" && txtSoLuongGhe.Text.Trim() != "")
            {
                try
                {
                    PlaneDTO dto = new PlaneDTO(txtMaMayBay.Text, txtTenMayBay.Text, Convert.ToInt32(txtSoLuongGhe.Text));
                    if (planbus.InsertPlane(dto))
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
            if (txtMaMayBay.Text.Trim() != "")
            {
                if (txtTenMayBay.Text.Trim() != "" && txtSoLuongGhe.Text.Trim() != "")
                {
                    try
                    {
                        PlaneDTO dto = new PlaneDTO(txtMaMayBay.Text, txtTenMayBay.Text, Convert.ToInt32(txtSoLuongGhe.Text));
                        if (planbus.UpdatePlane(dto))
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
            if (txtMaMayBay.Text.Trim() != "")
            {
                try
                {
                    if (planbus.DeletePlane(txtMaMayBay.Text))
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
            dtgvMayBay.DataSource = planbus.SearchByName(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
