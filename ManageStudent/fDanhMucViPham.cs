using BusinessLayer;
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
    public partial class fDanhMucViPham : DevExpress.XtraEditors.XtraForm
    {
        public fDanhMucViPham()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        HOCKY _hk;
        KHOA _khoi;
        NAMHOC _nh;
        LOP _lop;
        VIPHAM _vp;
        int _id = 0;
        private void fDanhMucViPham_Load(object sender, EventArgs e)
        {
            //_showHide(true);
            _hk = new HOCKY();
            _nh = new NAMHOC();
            _lop = new LOP();
            _khoi = new KHOA();
            _vp = new VIPHAM();
            LoadData();
            getListVP();
            cbKhoiLop.SelectedIndexChanged += CbKhoiLop_SelectedIndexChanged;
            cbNamHoc.SelectedIndexChanged += CbNamHoc_SelectedIndexChanged;
        }

        private void CbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHocKy.DataSource = _hk.getList(int.Parse(cbNamHoc.SelectedValue.ToString()));
            cbHocKy.DisplayMember = "TENHK";
            cbHocKy.ValueMember = "MAHK";
        }

        private void CbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLop.DataSource = _lop.getList(int.Parse(cbKhoiLop.SelectedValue.ToString()));
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        public void getListVP()
        {
            gcDanhSach.DataSource = _vp.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()), int.Parse(cbHocKy.SelectedValue.ToString()));
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void LoadData()
        {
            cbNamHoc.DataSource = _nh.getList();
            cbNamHoc.DisplayMember = "TENNH";
            cbNamHoc.ValueMember = "MANH";

            cbHocKy.DataSource = _hk.getList(int.Parse(cbNamHoc.SelectedValue.ToString()));
            cbHocKy.DisplayMember = "TENHK";
            cbHocKy.ValueMember = "MAHK";

            cbKhoiLop.DataSource = _khoi.getList();
            cbKhoiLop.DisplayMember = "TENKHOI";
            cbKhoiLop.ValueMember = "MAKHOI";

            cbLop.DataSource = _lop.getList(int.Parse(cbKhoiLop.SelectedValue.ToString()));
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        void _showHide(bool kt)
        {
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            cbHocKy.Enabled = !kt;
            cbKhoiLop.Enabled = !kt;
            cbLop.Enabled = !kt;
            cbNamHoc.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fQuanLyViPham f = new fQuanLyViPham();
            f._them = true;
            f.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fQuanLyViPham f = new fQuanLyViPham();
            f._them = false;
            f.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _vp.Delete(_id, Commons.UserStatic.UID);
            }
        }

        
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}