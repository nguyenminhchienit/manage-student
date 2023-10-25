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
    public partial class fLop : Form
    {
        public fLop()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        LOP _l;
        int _id = 0;

        private void fLop_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _l = new LOP();
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
            txtLop.Enabled = !kt;
            cbKhoi.Enabled = !kt;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _l.getListFull();
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _l.Delete(_id, Commons.UserStatic.UID);
                LoadData();
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
                tb_Lop _lop = new tb_Lop();
                _lop.TENLOP = txtLop.Text;
                _lop.MAKHOI = int.Parse(cbKhoi.SelectedValue.ToString());
                _l.Add(_lop);
            }
            else
            {
                tb_Lop _lop = _l.getItem(_id);
                _lop.TENLOP = txtLop.Text;
                _lop.MAKHOI = int.Parse(cbKhoi.SelectedValue.ToString());
                _l.Update(_lop);
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MALOP").ToString());
                txtLop.Text = (gvDanhSach.GetFocusedRowCellValue("TENLOP").ToString());
                cbKhoi.Text = (gvDanhSach.GetFocusedRowCellValue("TENKHOI").ToString());
            }
        }
    }
}
