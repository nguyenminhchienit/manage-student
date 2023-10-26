using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Chuyển đổi byte thành dạng chuỗi hex
                }
                return builder.ToString();
            }
        }

        user _u = new user();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string hashPassword = HashPassword(txtPassword.Text);
            if (!hashPassword.Equals(Commons.UserStatic.PASSWORD))
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                //MessageBox.Show(Commons.UserStatic.USERNAME);
                string hashPasswordNew = HashPassword(txtNewPassword.Text);
                tb_User user = _u.getItem(Commons.UserStatic.USERNAME);
                user.PASSWORD = hashPasswordNew;
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
