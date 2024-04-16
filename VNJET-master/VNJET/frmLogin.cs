using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNJET
{
    public partial class frmLogin : Form
    {
        StaffBUS staffbus = new StaffBUS();
        
        public frmLogin()
        {
            InitializeComponent();
            LoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool LoginAndGetData(string user, string pass, out DataTable userData)
        {
            try
            {
                int result = staffbus.CheckLoginFirst(user, pass);

                switch (result)
                {
                    case 1:
                        // Đăng nhập thành công
                        string query = $"SELECT * FROM dbo.Accounts WHERE userAcc='{user}' AND passAcc='{pass}'";
                        userData = DataProvider.Instance.ExecuteQuery(query);
                        return true;
                    case 0:
                        MessageBox.Show("Sai tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userData = null;
                        return false;
                    case -1:
                        MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userData = null;
                        return false;
                    default:
                        MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userData = null;
                        return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi từ cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userData = null;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập không thành công! Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userData = null;
                return false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataTable userData;
                if (LoginAndGetData(txtUsername.Text, txtPassword.Text, out userData))
                {
                    DataRow row = userData.Rows[0];
                    Form frm = new frmMain(row);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadForm()
        {
            txtUsername.Focus();

            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnDangNhap.TabIndex = 2;
            btnThoat.TabIndex = 3;

            txtPassword.UseSystemPasswordChar = true;

            AcceptButton = btnDangNhap;
            CancelButton = btnThoat;
        }
    }
}
