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
    public partial class frmQuanLyHangVe : Form
    {
        TicketClassBUS ticketclassbus = new TicketClassBUS();
        public frmQuanLyHangVe()
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
            LoadDTGVTicketClass();
            txtMaHangVe.Clear();
            txtTenHangVe.Clear();
        }
        private void LoadForm()
        {
            LoadDTGVTicketClass();
            txtTenHangVe.Focus();
        }

        private void LoadDTGVTicketClass()
        {
            DataTable dtHangVe = ticketclassbus.GetForDisplay();
            dtgvHangVe.DataSource = dtHangVe;
            dtgvHangVe.Columns[0].HeaderText = "Mã hạng vé";
            dtgvHangVe.Columns[1].HeaderText = "Tên hạng vé";
            dtgvHangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvHangVe.Rows[e.RowIndex];
            txtMaHangVe.Text = row.Cells[0].Value.ToString();
            txtTenHangVe.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenHangVe.Text.Trim() != "")
            {
                try
                {
                    TicketClassDTO dto = new TicketClassDTO(txtMaHangVe.Text, txtTenHangVe.Text);
                    if (ticketclassbus.InsertTicketClass(dto))
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
            if (txtMaHangVe.Text.Trim() != "")
            {
                if (txtTenHangVe.Text.Trim() != "")
                {
                    try
                    {
                        TicketClassDTO dto = new TicketClassDTO(txtMaHangVe.Text, txtTenHangVe.Text);
                        if (ticketclassbus.UpdateTicketClass(dto))
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
            if (txtMaHangVe.Text.Trim() != "")
            {
                try
                {
                    if (ticketclassbus.DeleteTicketClass(txtMaHangVe.Text))
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
            dtgvHangVe.DataSource = ticketclassbus.SearchByName(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
