using DAO;
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
    public partial class frmMain : Form
    {
        private DataRow rowStaff;
        public frmMain(DataRow row)
        {
            InitializeComponent();
            rowStaff = row;
            LoadForm();
        }
        private void LoadForm()
        {
            lbMaNhanVien.Text = "Mã nhân viên: " + rowStaff[2].ToString();
            lbUsername.Text = "Username: " + rowStaff[0].ToString();
            int type = Convert.ToInt32(rowStaff[3].ToString());
            DataProvider.Instance.Decentralize(type);
            if (type == 1)
            {
                mstrMain.Enabled = true;
                toolStripMain.Enabled = true;
            }
            else
            {
                mstrMain.Enabled = true;
                toolStripMain.Enabled = true;
                QuanLyThongTinToolStripMenuItem.Enabled = false;
                baoCaoToolStripMenuItem.Enabled = false;
            }
        }
        private bool CheckExistForm(Form frm)
        {
            foreach (TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void ActiveChildForm(Form frm)
        {
            foreach (TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    tabCtrlMain.SelectedTab = t;
                    break;
                }
            }
        }
        private TabPage CreateTabPage(Form frm)
        {
            TabPage tabPage = new TabPage { Text = frm.Text };
            tabPage.BorderStyle = BorderStyle.None;
            tabCtrlMain.TabPages.Add(tabPage);
            tabCtrlMain.SelectedTab = tabPage;
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.BackColor = Color.White;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            return tabPage;
        }

        private void toolStripBtnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new frmLogin();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new frmLogin();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void thoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void banVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanVe frm = new frmBanVe(rowStaff);
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyChuyenBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyChuyenBay frm = new frmQuanLyChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyTuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTuyenBay frm = new frmQuanLyTuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLySanBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanBay frm = new frmQuanLySanBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyMayBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMayBay frm = new frmQuanLyMayBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyHangVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHangVe frm = new frmQuanLyHangVe();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyDonGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDonGia frm = new frmQuanLyDonGia();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void traCuuChuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void toolStripBtnBanVe_Click(object sender, EventArgs e)
        {
            frmBanVe frm = new frmBanVe(rowStaff);
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void toolStripBtnTraCuuChuyenBay_Click(object sender, EventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
    }
}
