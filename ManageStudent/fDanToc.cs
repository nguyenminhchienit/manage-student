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
    public partial class fDanToc : Form
    {
        public fDanToc()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

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
                _dt.Delete(_id, Commons.UserStatic.UID);
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
                tb_DanToc _dantoc = new tb_DanToc();
                _dantoc.TENDT = txtDanToc.Text;
                _dantoc.CREATEDBY = Commons.UserStatic.UID;
                _dantoc.CREATEDDATE = DateTime.Now;
                _dt.Add(_dantoc);
            }
            else
            {
                tb_DanToc _dantoc = _dt.getItem(_id);
                _dantoc.TENDT = txtDanToc.Text;
                _dantoc.UPDATEDBY = Commons.UserStatic.UID;
                _dantoc.UPDATEDDATE = DateTime.Now;
                _dt.Update(_dantoc);
            }
        }

        bool _them;
        DANTOC _dt;
        int _id = 0;
        private void fDanToc_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _dt = new DANTOC();
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
            txtDanToc.Enabled = !kt;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _dt.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MADT").ToString());
                txtDanToc.Text = (gvDanhSach.GetFocusedRowCellValue("TENDT").ToString());
            }
        }
    }
}
