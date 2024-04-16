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
    public partial class frmQuanLyDonGia : Form
    {
        PriceBUS pricebus = new PriceBUS();
        FlightRouteBUS flightroutebus = new FlightRouteBUS();
        AirportBUS airportbus = new AirportBUS();
        TicketClassBUS ticketclassbus = new TicketClassBUS();
        bool flagCellClick;
        public frmQuanLyDonGia()
        {
            InitializeComponent();
            flagCellClick = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void Recreate()
        {
            LoadDTGVPrice();
            txtDonGia.Clear();
        }
        private void LoadForm()
        {
            DataTable dtTuyenBay = flightroutebus.GetForDisplay();
            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "idFlightRoutes";
            cboMaTuyenBay.ValueMember = "idFlightRoutes";

            DataTable dtHangVe = ticketclassbus.GetForDisplay();
            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "nameTicketClass";
            cboMaHangVe.ValueMember = "idTicketClass";

            DataTable dtSanBayDi = airportbus.GetForDisplay();
            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "nameAirport";
            cboSanBayDi.ValueMember = "idAirport";

            DataTable dtSanBayDen = airportbus.GetForDisplay();
            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "nameAirport";
            cboSanBayDen.ValueMember = "idAirport";

            LoadDTGVPrice();

            cboSanBayDi.Focus();
        }
        private void LoadDTGVPrice()
        {
            DataTable dtDonGia = pricebus.GetForDisplay();
            dtgvDonGia.DataSource = dtDonGia;
            dtgvDonGia.Columns[0].HeaderText = "Mã tuyến bay";
            dtgvDonGia.Columns[1].HeaderText = "Mã hạng vé";
            dtgvDonGia.Columns[2].HeaderText = "Đơn giá";
            dtgvDonGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDonGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgvDonGia.Columns[2].DefaultCellStyle.Format = "#,####.####";
        }

        private void dtgvDonGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvDonGia.Rows[e.RowIndex];
            cboMaTuyenBay.SelectedValue = row.Cells[0].Value.ToString();
            cboMaHangVe.SelectedValue = row.Cells[1].Value.ToString();
            txtDonGia.Text = row.Cells[2].Value.ToString();
            flagCellClick = true;
            cboMaTuyenBay_SelectionChangeCommitted(sender, e);
        }

        private void cboMaTuyenBay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtTuyenBay = flightroutebus.GetOfIdFlightRoute(cboMaTuyenBay.SelectedValue.ToString());
            if (dtTuyenBay.Rows.Count == 0)
                return;
            DataRow row = dtTuyenBay.Rows[0];

            cboSanBayDi.SelectedValue = row["idAirportToGo"].ToString();

            cboSanBayDen.SelectedValue = row["idAirportToCome"].ToString();
        }

        private void cboSanBayDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtTuyenBay = flightroutebus.GetOfIdAirport(cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
            if (dtTuyenBay.Rows.Count == 0)
            {
                cboMaTuyenBay.Text = "";
            }
            else
            {
                DataRow row = dtTuyenBay.Rows[0];
                cboMaTuyenBay.Text = row["idFlightRoutes"].ToString();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                lbDonGia.Text = "";
                return;
            }
            decimal value = Convert.ToDecimal(txtDonGia.Text);
            lbDonGia.Text = string.Format("{0:0,0 VNĐ}", value);
        }

        private void frmQuanLyDonGia_Shown(object sender, EventArgs e)
        {
            LoadForm();
            cboMaTuyenBay_SelectionChangeCommitted(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaTuyenBay.Text.Trim() != "" && cboMaHangVe.Text.Trim() != "" && txtDonGia.Text != "")
            {
                if (cboSanBayDi.Text == cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    PriceDTO dto = new PriceDTO(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                    if (pricebus.InsertPrice(dto))
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
            if (flagCellClick)
            {

                if (cboSanBayDi.Text == cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
                {
                    try
                    {
                        PriceDTO dto = new PriceDTO(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                        if (pricebus.UpdatePrice(dto))
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
                        flagCellClick = false;
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
            if (flagCellClick)
            {
                try
                {
                    PriceDTO dto = new PriceDTO(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                    if (pricebus.DeletePrice(dto))
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
                    flagCellClick = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvDonGia.DataSource = pricebus.SearchById(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
    }
}
