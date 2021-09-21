using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.DAL;
using Parking.DTO;

namespace Parking.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void check_show_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_hide.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }

        private bool checkPwd(string username, string pwd)
        {
            AccountDTO getAccountInfo = Account_DAO.Instance.getAccByID(username);
            return Account_DAO.Instance.login(username, pwd);
        }

        void login()
        {

            String username = txtUsername.Text;
            String pwd = txtPass.Text;
            if (username != "" && pwd != "")
            {
                if (checkPwd(username, (pwd)) == true)
                {
                    this.Hide();
                    AccountDTO getAccountInfo = Account_DAO.Instance.getAccByID(username);
                    frmParking pk = new frmParking(getAccountInfo);
                    pk.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thiếu", "Lỗi");
            }
        }

        private void btnLongin_Click(object sender, EventArgs e)
        {
            login();
        }


        private void btnChang_pass_Click(object sender, EventArgs e)
        {
            frmChangePass changepass = new frmChangePass();
            this.Hide();
            changepass.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
