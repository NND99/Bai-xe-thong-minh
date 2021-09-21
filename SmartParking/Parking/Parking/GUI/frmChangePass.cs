using Parking.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.GUI
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnChang_pass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPass.Text;
            string type = cbType.SelectedItem.ToString();

            if (pwd != "" && type != "")
            {
                Account_DAO.Instance.changepwdByID(username, pwd);
                MessageBox.Show("Sửa tài khoản thành công", "Thành công");
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi");
            }

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

        void cancel()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            cbType.Text = "";

            if (bgwChangePass.IsBusy != true)
            {
                bgwChangePass.RunWorkerAsync();
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();
        }
    }
}
