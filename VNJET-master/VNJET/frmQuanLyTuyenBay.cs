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
    public partial class frmQuanLyTuyenBay : Form
    {
        FlightRouteBUS flightroutebus = new FlightRouteBUS();
        AirportBUS airportbus = new AirportBUS();
        public frmQuanLyTuyenBay()
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
            LoadDTGVFlightRoute();
            txtMaTuyenBay.Clear();
            cboSanBayDen.Text = "";
            cboSanBayDi.Text = "";
            cboSanBayDi.Focus();
        }
        private void LoadForm()
        {

            DataTable dtSanBayDen = airportbus.GetForDisplay();
            DataTable dtSanBayDi = airportbus.GetForDisplay();

            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "nameAirport";
            cboSanBayDen.ValueMember = "idAirport";

            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "nameAirport";
            cboSanBayDi.ValueMember = "idAirport";

            LoadDTGVFlightRoute();

            cboSanBayDi.Focus();
        }
        
        private void LoadDTGVFlightRoute()
        {
            DataTable dtTuyenBay = flightroutebus.GetForDisplay();
            dtgvTuyenBay.DataSource = dtTuyenBay;
            dtgvTuyenBay.Columns[0].HeaderText = "Mã tuyến bay";
            dtgvTuyenBay.Columns[1].HeaderText = "Mã sân bay đi";
            dtgvTuyenBay.Columns[2].HeaderText = "Tên sân bay đi";
            dtgvTuyenBay.Columns[3].HeaderText = "Mã sân bay đến";
            dtgvTuyenBay.Columns[4].HeaderText = "Tên sân bay đến";
            dtgvTuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtgvTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvTuyenBay.Rows[e.RowIndex];
            txtMaTuyenBay.Text = row.Cells[0].Value.ToString();
            cboSanBayDi.Text = row.Cells[2].Value.ToString();
            cboSanBayDen.Text = row.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
            {
                if (cboSanBayDi.Text == cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    FlightRouteDTO dto = new FlightRouteDTO(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                    if (flightroutebus.InsertFlightRoute(dto))
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
            if (txtMaTuyenBay.Text.Trim() != "")
            {
                if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
                {
                    if (cboSanBayDi.Text == cboSanBayDen.Text)
                    {
                        MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        FlightRouteDTO dto = new FlightRouteDTO(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                        if (flightroutebus.UpdateFlightRoute(dto))
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
            if (txtMaTuyenBay.Text.Trim() != "")
            {
                try
                {
                    if (flightroutebus.DeleteFlightRoute(txtMaTuyenBay.Text))
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
            dtgvTuyenBay.DataSource = flightroutebus.SearchByName(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
