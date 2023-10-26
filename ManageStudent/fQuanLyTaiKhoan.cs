using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            u = new user();
        }

        user u;
        void saveData()
        {
            
             tb_User _user = new tb_User();
            _user.USERNAME = txtUsername.Text;
            _user.PASSWORD = txtPassword.Text;
            _user.FULLNAME = "";
            _user.ROLE = cbRole.Text;
            _user.EMAIL = txtGmail.Text;
            u.Add(_user);
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "" || txtRePassword.Text == "" || cbRole.Text == "" || txtGmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            saveData();
            MessageBox.Show("Bạn đã đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
