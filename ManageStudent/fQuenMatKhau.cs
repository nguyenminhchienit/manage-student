using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent
{
    public partial class fQuenMatKhau : Form
    {
        public fQuenMatKhau()
        {
            InitializeComponent();
        }

        Random rd = new Random();
        int otp;

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = rd.Next(100000, 1000000);
                var fromAddress = new MailAddress("takistech.dev@gmail.com");
                var toAddress = new MailAddress(txtEmail.ToString());

                const string formPass = "lmmurjvsuzljajxr";
                const string subject = "OTP Code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, formPass),
                    Timeout = 200000
                };
                using (var mes = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mes);
                }
                MessageBox.Show("OTP đã được gửi qua email!", "Thông báo OTP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (otp.ToString().Equals(txtOTP.Text))
            {
                string email = txtEmail.Text;
                string password = txtMK.Text;
                string hashPassword = HashPassword(password);
                string rePassword = txtReMK.Text;
                if (password.Equals(rePassword))
                {
                    if (ForgotAccount(email, hashPassword))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác");
                }
            }
            else
            {
                MessageBox.Show("OTP không chính xác");
            }
        }

        user _u = new user();
        private bool ForgotAccount(string email, string password)
        {
            tb_User user = _u.getItemByEmail(email);
            user.PASSWORD = password;
            _u.Update(user);
            return true;
        }
    }
}
