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
    public partial class fHocKy : DevExpress.XtraEditors.XtraForm
    {
        public fHocKy()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        HOCKY _hk;
        NAMHOC _nh;
        int _id = 0;

        private void fHocKy_Load(object sender, EventArgs e)
        {
            _hk = new HOCKY();
            _nh = new NAMHOC();
            _showHide(true);
            LoadNamHoc();
            cbNamHoc.SelectedIndexChanged += CbNamHoc_SelectedIndexChanged;
            LoadData();
        }

        private void CbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _hk.getList(int.Parse(cbNamHoc.SelectedValue.ToString()));
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void LoadNamHoc()
        {
            cbNamHoc.DataSource = _nh.getList();
            cbNamHoc.DisplayMember = "TENNH";
            cbNamHoc.ValueMember = "MANH";
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
            cbNamHoc.Enabled = !kt;
            txtHocKy.Enabled = !kt;
            spHeSoHK.Enabled = !kt;     
        }

        void saveData()
        {
            if (_them)
            {
                tb_HocKy _hocky = new tb_HocKy();
                _hocky.TENHK = txtHocKy.Text;
                _hocky.HESO = int.Parse(spHeSoHK.Text);
                _hocky.MANH = int.Parse(cbNamHoc.SelectedValue.ToString());
                _hocky.CREATEDBY = Commons.UserStatic.UID;
                _hocky.CREATEDDATE = DateTime.Now;
                _hk.Add(_hocky);
            }
            else
            {
                tb_HocKy _hocky = _hk.getItem(_id);
                _hocky.TENHK = txtHocKy.Text;
                _hocky.HESO = int.Parse(spHeSoHK.Text);
                _hocky.MANH = int.Parse(cbNamHoc.SelectedValue.ToString());
                _hocky.UPDATEDBY = Commons.UserStatic.UID;
                _hocky.UPDATEDDATE = DateTime.Now;
                _hk.Update(_hocky);
            }
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
                _hk.Delete(_id, Commons.UserStatic.UID);
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

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAHK").ToString());
            var hk = _hk.getItem(_id);
            txtHocKy.Text = hk.TENHK;
            spHeSoHK.Text = (gvDanhSach.GetFocusedRowCellValue("HESO").ToString());
            cbNamHoc.SelectedValue = hk.MANH;
        }
    }
}