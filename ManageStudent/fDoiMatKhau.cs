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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        user _u = new user();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!txtPassword.Text.Equals(Commons.UserStatic.PASSWORD))
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Commons.UserStatic.USERNAME);
                tb_User user = _u.getItem(Commons.UserStatic.USERNAME);
                user.PASSWORD = txtNewPassword.Text;
                _u.Update(user);

                DialogResult result = MessageBox.Show("Bạn đã đổi mật khẩu thành công, Bạn phải đăng nhập lại?", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    // Hiển thị form đăng nhập
                    fLogin loginForm = new fLogin();
                    loginForm.ShowDialog();

                }
            }
        }
    }
}
