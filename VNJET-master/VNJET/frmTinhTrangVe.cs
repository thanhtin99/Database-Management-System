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
    public partial class frmTinhTrangVe : Form
    {
        FlightBUS flightBUS = new FlightBUS();
        TicketStatusBUS ticketStatusBUS = new TicketStatusBUS();
        TicketClassBUS ticketClassBUS = new TicketClassBUS();
        string idFlight;
        public frmTinhTrangVe(string maChuyenBay)
        {
            InitializeComponent();
            this.idFlight = maChuyenBay;
            LoadForm();
        }

        private void LoadForm()
        {
            cboMaChuyenBay.Focus();
            DataTable dtCB = flightBUS.GetForDisplay();
            cboMaChuyenBay.DataSource = dtCB;
            cboMaChuyenBay.DisplayMember = "idFlights";
            cboMaChuyenBay.ValueMember = "idFlights";
            cboMaChuyenBay.Text = idFlight;
            LoadDtgv(idFlight);
        }
        private void LoadDtgv(string maChuyenBay)
        {
            DataTable dtTinhTrangVe = ticketStatusBUS.GetTicketStatusByIdFlight(maChuyenBay);
            dtgvTinhTrangVe.DataSource = dtTinhTrangVe;
            dtgvTinhTrangVe.Columns[0].HeaderText = "Tên hạng vé";
            dtgvTinhTrangVe.Columns[1].HeaderText = "Tổng số ghế";
            dtgvTinhTrangVe.Columns[2].HeaderText = "Tổng số ghế trống";
            dtgvTinhTrangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTinhTrangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDtgv(cboMaChuyenBay.Text);
        }
    }
}
