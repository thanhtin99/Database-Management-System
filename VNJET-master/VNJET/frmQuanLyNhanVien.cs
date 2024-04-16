using BUS;
using DAO;
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
    public partial class frmQuanLyNhanVien : Form
    {
        StaffBUS staffbus = new StaffBUS();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            LoadDTGVStaff();
            txtName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void LoadDTGVStaff()
        {
            DataTable dtNhanVien = staffbus.GetForDisplay();
            dtgvNhanVien.DataSource = dtNhanVien;
            dtgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dtgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns[3].HeaderText = "SĐT";
            dtgvNhanVien.Columns[4].HeaderText = "Username";
            dtgvNhanVien.Columns[5].HeaderText = "Chức vụ";
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];
            txtMaNhanVien.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtPhone.Text = row.Cells[3].Value.ToString();
            txtUsername.Text = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value.ToString() == "0")
            {
                rdbtnNVQuanTri.Checked = false;
                rdbtnNVBanVe.Checked = true;
            }
            else
            {
                rdbtnNVQuanTri.Checked = true;
                rdbtnNVBanVe.Checked = false;
            }
        }

        private void Recreate()
        {
            LoadDTGVStaff();
            txtMaNhanVien.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            rdbtnNVQuanTri.Checked = false;
            rdbtnNVBanVe.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtAddress.Text.Trim() != "" && 
                txtPhone.Text.Trim() != "" && txtUsername.Text.Trim() != "" )
            {
                int type = 0;
                if (rdbtnNVQuanTri.Checked)
                    type = 1;
                if (rdbtnNVBanVe.Checked)
                    type = 0;
                try
                {
                    StaffDTO dto = new StaffDTO(txtMaNhanVien.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtUsername.Text, type);
                    if (staffbus.InsertStaff(dto))
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
            if (txtMaNhanVien.Text.Trim() != "")
            {
                if (txtName.Text.Trim() != "" && txtAddress.Text.Trim() != "" &&
                    txtPhone.Text.Trim() != "" && txtUsername.Text.Trim() != "")
                {
                    int type = 0;
                    if (rdbtnNVQuanTri.Checked)
                        type = 1;
                    if (rdbtnNVBanVe.Checked)
                        type = 0;
                    try
                    {
                        StaffDTO dto = new StaffDTO(txtMaNhanVien.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtUsername.Text, type);
                        if (staffbus.UpdateStaff(dto))
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
            if (txtMaNhanVien.Text.Trim() != "")
            {
                try
                {
                    if (staffbus.DeleteStaff(txtMaNhanVien.Text))
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
            dtgvNhanVien.DataSource = staffbus.SearchByName(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
