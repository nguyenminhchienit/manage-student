using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }


        user _user;

        private void fLogin_Load(object sender, EventArgs e)
        {
            _user = new user();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        public static bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword);
            return string.Equals(hashedEnteredPassword, storedHashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashPassword = HashPassword(txtPassword.Text);
            int login = _user.Login(txtUsername.Text, hashPassword);
            if (login == 1)
            {
                Commons.UserStatic = _user.getItem(txtUsername.Text);
                fMain main = (fMain)Application.OpenForms["fMain"];
                main.lbFullName.Caption = Commons.UserStatic.FULLNAME;
                if (Commons.handle != null)
                {
                    SplashScreenManager.CloseOverlayForm(Commons.handle);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            fQuenMatKhau f = new fQuenMatKhau();
            f.ShowDialog();
        }
    }
}