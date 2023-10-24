using BusinessLayer;
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
    public partial class fXemDiem : Form
    {
        public fXemDiem()
        {
            InitializeComponent();
        }

        HOCKY _hk;
        KHOA _khoi;
        HOCSINH _hs;
        NAMHOC _nh;
        LOP _lop;
        HOCSINH_LOP_NAMHOC _hsl;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = _hs.getListDiem(int.Parse(cbLop.SelectedValue.ToString()));
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

        private void fXemDiem_Load(object sender, EventArgs e)
        {
            _hk = new HOCKY();
            _nh = new NAMHOC();
            _lop = new LOP();
            _hs = new HOCSINH();
            _khoi = new KHOA();
            _hsl = new HOCSINH_LOP_NAMHOC();

            LoadData();
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

    }
}
