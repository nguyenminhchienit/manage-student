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
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        bool _them;
        user _u;
        int _id = 0;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _u = new user();
            LoadData();
        }

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtUserName.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtFullName.Enabled = !kt;
            txtPassword.Enabled = !kt;
            cbRole.Enabled = !kt;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _u.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
            txtPassword.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_u.Delete(_id, Commons.UserStatic.UID))
                {
                    LoadData();
                    MessageBox.Show("Xóa tài khoản thành công? ", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể xóa chính mình? ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            LoadData();
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        void saveData()
        {
            
            if (_them)
            {
                if (txtUserName.Text == "" || txtPassword.Text == "" || txtFullName.Text == "" || cbRole.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                tb_User _user = new tb_User();
                _user.USERNAME = txtUserName.Text;
                _user.FULLNAME = txtFullName.Text;
                _user.PASSWORD = txtPassword.Text;
                _user.ROLE = cbRole.Text;
                _user.EMAIL = txtEmail.Text;
                _u.Add(_user);
            }
            else
            {
                if (txtUserName.Text == "" || txtFullName.Text == "" || cbRole.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                tb_User _user = _u.getItemByID(_id);
                _user.USERNAME = txtUserName.Text;
                _user.FULLNAME = txtFullName.Text;
                _user.ROLE = cbRole.Text;
                _user.EMAIL = txtEmail.Text;
                _u.Update(_user);
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("UID").ToString());
                txtUserName.Text = (gvDanhSach.GetFocusedRowCellValue("USERNAME").ToString());
                if((gvDanhSach.GetFocusedRowCellValue("FULLNAME").ToString()) == null)
                {
                    txtFullName.Text = "";
                }
                else
                {
                    txtFullName.Text = (gvDanhSach.GetFocusedRowCellValue("FULLNAME").ToString());
                }
                txtEmail.Text = (gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString());
                cbRole.Text = (gvDanhSach.GetFocusedRowCellValue("ROLE").ToString());
            }
        }
    }
}
