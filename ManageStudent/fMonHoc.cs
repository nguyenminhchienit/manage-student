using BusinessLayer;
using DataAccessLayer;
using DevExpress.XtraEditors;
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
    public partial class fMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public fMonHoc()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        MONHOC _mh;
        int _id = 0;

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            _mh = new MONHOC();
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
            txtMonHoc.Enabled = !kt;
            spHeSo.Enabled = !kt;
            spSoTiet.Enabled = !kt;
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
            if(MessageBox.Show("Bạn có chắc muốn xóa không? ","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _mh.Delete(_id, Commons.UserStatic.UID);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            LoadData();
            _showHide(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        void saveData()
        {
            if (_them)
            {
                tb_MonHoc _monhoc = new tb_MonHoc();
                _monhoc.TENMH = txtMonHoc.Text;
                _monhoc.SOTIET = int.Parse(spSoTiet.Text);
                _monhoc.HESO = int.Parse(spHeSo.Text);
                _monhoc.CREATEDBY = Commons.UserStatic.UID;
                _monhoc.CREATEDDATE = DateTime.Now;
                _mh.Add(_monhoc);
            }
            else
            {
                tb_MonHoc _monhoc = _mh.getItem(_id);
                _monhoc.TENMH = txtMonHoc.Text;
                _monhoc.SOTIET = int.Parse(spSoTiet.Text);
                _monhoc.HESO = int.Parse(spHeSo.Text);
                _monhoc.UPDATEDBY = Commons.UserStatic.UID;
                _monhoc.UPDATEDDATE = DateTime.Now;
                _mh.Update(_monhoc);
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _mh.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAMH").ToString());
                txtMonHoc.Text = (gvDanhSach.GetFocusedRowCellValue("TENMH").ToString());
                spHeSo.Text = (gvDanhSach.GetFocusedRowCellValue("HESO").ToString());
                spSoTiet.Text = (gvDanhSach.GetFocusedRowCellValue("SOTIET").ToString());
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name == "DELETEDBY" && e.CellValue != null)
            {
                Image img = Properties.Resources.Delete_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}