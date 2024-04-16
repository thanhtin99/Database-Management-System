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
    public partial class frmQuanLyChuyenBay : Form
    {
        FlightBUS flightbus = new FlightBUS();
        FlightRouteBUS flightroutebus = new FlightRouteBUS();
        PlaneBUS planebus = new PlaneBUS();
        TicketClassBUS ticketclassbus = new TicketClassBUS();
        AirportBUS airportbus = new AirportBUS();
        TicketStatusBUS ticketstatusbus = new TicketStatusBUS();
        bool flagHangVeCellClick;
        int seatsold = 0;
        public frmQuanLyChuyenBay()
        {
            InitializeComponent();
            LoadAll();
        }
        
        private void LoadAll()
        {
            LoadFormFlight();
            LoadFormTicketClass();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }


        #region Flight
        private void RecreateChuyenBay()
        {
            LoadDTGVFlight();
            gbxThemHangVeChoChuyenBay.Enabled = false;
        }
        private void gbxThemHangVeChoChuyenBay_CursorChanged(object sender, EventArgs e)
        {
            AcceptButton = btnThemHV;
        }

        private void LoadFormFlight()
        {
            DataTable dtTuyenBay = flightroutebus.GetForDisplay();
            DataTable dtMayBay = planebus.GetForDisplay();
            DataTable dtHangVe = ticketclassbus.GetForDisplay();
            DataTable dtSanBayDi = airportbus.GetForDisplay();
            DataTable dtSanBayDen = airportbus.GetForDisplay();

            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "idFlightRoutes";
            cboMaTuyenBay.ValueMember = "idFlightRoutes";

            cboMaMayBay.DataSource = dtMayBay;
            cboMaMayBay.DisplayMember = "idPlane";
            cboMaMayBay.ValueMember = "idPlane";

            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "nameTicketClass";
            cboMaHangVe.ValueMember = "idTicketClass";

            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "nameAirport";
            cboSanBayDi.ValueMember = "idAirport";

            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "nameAirport";
            cboSanBayDen.ValueMember = "idAirport";

            gbxThemHangVeChoChuyenBay.Enabled = false;

            AcceptButton = btnThem;
            CancelButton = btnThoat;

            LoadDTGVFlight();
        }

        private void LoadDTGVFlight()
        {
            DataTable dtChuyenBay = flightbus.GetForDisplay();
            dtgvChuyenBay.DataSource = dtChuyenBay;
            dtgvChuyenBay.Columns[0].HeaderText = "Mã chuyến bay";
            dtgvChuyenBay.Columns[1].HeaderText = "Mã tuyến bay";
            dtgvChuyenBay.Columns[2].HeaderText = "Mã máy bay";
            dtgvChuyenBay.Columns[3].HeaderText = "Thời gian khởi hành";
            dtgvChuyenBay.Columns[4].HeaderText = "Thời gian hạ cánh";
            dtgvChuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void cboMaTuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMaTuyenBay.SelectedValue != null)
            {
                DataTable dtTuyenBay = flightroutebus.GetOfIdFlightRoute(cboMaTuyenBay.SelectedValue.ToString());
                if (dtTuyenBay.Rows.Count == 0)
                    return;
                else
                {
                    DataRow row = dtTuyenBay.Rows[0];
                    cboSanBayDi.Text = row[2].ToString();
                    cboSanBayDi.SelectedValue = row[1].ToString();
                    cboSanBayDen.Text = row[4].ToString();
                    cboSanBayDen.SelectedValue = row[3].ToString();
                }
            }
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

        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells[0].Value.ToString();
            cboMaTuyenBay.Text = row.Cells[1].Value.ToString();
            cboMaMayBay.Text = row.Cells[2].Value.ToString();
            dtpkThoiGianKhoiHanh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            dtpkThoiGianHaCanh.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
            gbxThemHangVeChoChuyenBay.Enabled = true;

            LoadDTGVTicketClassForFlight();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvChuyenBay.DataSource = flightbus.SearchById(txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaTuyenBay.Text.Trim() != "" && cboMaMayBay.Text.Trim() != "")
            {
                try
                {
                    FlightDTO dto = new FlightDTO(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, dtpkThoiGianKhoiHanh.Value, dtpkThoiGianHaCanh.Value);
                    if (flightbus.InsertFlight(dto))
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
                    RecreateChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text.Trim() != "")
            {
                if (cboMaTuyenBay.Text.Trim() != "" && cboMaMayBay.Text.Trim() != "")
                {
                    try
                    {
                        FlightDTO dto = new FlightDTO(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, dtpkThoiGianKhoiHanh.Value, dtpkThoiGianHaCanh.Value);
                        if (flightbus.UpdateFlight(dto))
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
                        RecreateChuyenBay();
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
            if (txtMaChuyenBay.Text.Trim() != "")
            {
                try
                {
                    if (flightbus.DeleteFlight(txtMaChuyenBay.Text))
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
                    RecreateChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region TicketClass
        private void RecreateHangVe()
        {
            LoadDTGVTicketClassForFlight();
            txtTongSoGhe.Text = "";
            flagHangVeCellClick = false;
        }
        private void LoadFormTicketClass()
        {
            DataTable dtHangVe = ticketclassbus.GetForDisplay();
            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "nameTicketClass";
            cboMaHangVe.ValueMember = "idTicketClass";
        }
        private void LoadDTGVTicketClassForFlight()
        {
            DataTable dtTicketclass = ticketclassbus.GetTicketClassForFlight(txtMaChuyenBay.Text);
            dtgvHangVe.DataSource = dtTicketclass;
            dtgvHangVe.Columns[0].HeaderText = "Mã chuyến bay";
            dtgvHangVe.Columns[1].HeaderText = "Tên hạng vé";
            dtgvHangVe.Columns[2].HeaderText = "Tổng số ghế";
            dtgvHangVe.Columns[3].HeaderText = "Tổng số ghế trống";
            dtgvHangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvHangVe.Rows[e.RowIndex];
            cboMaHangVe.Text = row.Cells[1].Value.ToString();
            txtTongSoGhe.Text = row.Cells[2].Value.ToString();

            seatsold = Convert.ToInt32(row.Cells[2].Value);
            flagHangVeCellClick = true;
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            object check = ticketstatusbus.CheckSeats(txtMaChuyenBay.Text);
            if (cboMaHangVe.Text != "" && txtTongSoGhe.Text != "")
            {
                if (Convert.ToInt32(check) >= Convert.ToInt32(txtTongSoGhe.Text))
                {
                    try
                    {
                        TicketStatusDTO dto = new TicketStatusDTO(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
                        if (ticketstatusbus.InsertTicketStatus(dto))
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
                        RecreateHangVe();
                    }
                }    
                else
                    MessageBox.Show(String.Format("Chỉ còn {0} ghế ngồi!", check), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            if (flagHangVeCellClick)
            {
                object check = ticketstatusbus.CheckSeats(txtMaChuyenBay.Text);
                int checkcv = Convert.ToInt32(check);
                if (cboMaHangVe.Text != "" && txtTongSoGhe.Text != "")
                {
                    if (checkcv+seatsold >= Convert.ToInt32(txtTongSoGhe.Text))
                    {
                        try
                        {
                            TicketStatusDTO dto = new TicketStatusDTO(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
                            if (ticketstatusbus.UpdateTicketStatus(dto))
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
                            RecreateHangVe();
                            flagHangVeCellClick = false;
                        }
                    }
                    else
                        MessageBox.Show(String.Format("Chỉ còn {0} ghế ngồi!", checkcv+seatsold), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            if (flagHangVeCellClick)
            {
                try
                {
                    TicketStatusDTO dto = new TicketStatusDTO(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
                    if (ticketstatusbus.DeleteTicketStatus(dto))
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
                    RecreateHangVe();
                    flagHangVeCellClick = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
