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
    public partial class fNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public fNamHoc()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        NAMHOC _nh;
        int _id = 0;

        private void fNamHoc_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _nh = new NAMHOC();
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
            txtNamHoc.Enabled = !kt;          
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
                _nh.Delete(_id, Commons.UserStatic.UID);
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

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            if (_them)
            {
                tb_NamHoc _namhoc = new tb_NamHoc();
                _namhoc.TENNH = txtNamHoc.Text;
                _namhoc.CREATEDBY = Commons.UserStatic.UID;
                _namhoc.CREATEDDATE = DateTime.Now;
                _nh.Add(_namhoc);
            }
            else
            {
                tb_NamHoc _namhoc = _nh.getItem(_id);
                _namhoc.TENNH = txtNamHoc.Text;
                _namhoc.UPDATEDBY = Commons.UserStatic.UID;
                _namhoc.UPDATEDDATE = DateTime.Now;
                _nh.Update(_namhoc);
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _nh.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

      
        

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANH").ToString());
                txtNamHoc.Text = (gvDanhSach.GetFocusedRowCellValue("TENNH").ToString());
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETEDBY" && e.CellValue != null)
            {
                Image img = Properties.Resources.Delete_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}