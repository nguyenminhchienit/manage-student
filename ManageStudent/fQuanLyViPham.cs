using BusinessLayer;
using BusinessLayer.DTO;
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
    public partial class fQuanLyViPham : DevExpress.XtraEditors.XtraForm
    {
        public fQuanLyViPham()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool _them;
        HOCKY _hk;
        KHOA _khoi;
        HOCSINH _hs;
        NAMHOC _nh;
        LOP _lop;
        DANHMUCLOI _vp;
        HOCSINH_LOP_NAMHOC _hsl;
        VIPHAM _vipham;
        CTVP _ctvp;
        List<vpctDTO> listCTVP;
        fDanhMucViPham objForm = (fDanhMucViPham)Application.OpenForms["fDanhMucViPham"];
        int _id = 0;

        private void fQuanLyViPham_Load(object sender, EventArgs e)
        {
            //_showHide(true);
            _hk = new HOCKY();
            _vp = new DANHMUCLOI();
            _nh = new NAMHOC();
            _lop = new LOP();
            _hs = new HOCSINH();
            _khoi = new KHOA();
            _hsl = new HOCSINH_LOP_NAMHOC();
            _vipham = new VIPHAM();
            _ctvp = new CTVP();
            listCTVP = new List<vpctDTO>();

            LoadData();
            LoadDanhMucLoi();
            LoadHocSinhLop();
            cbNamHoc.SelectedIndexChanged += CbNamHoc_SelectedIndexChanged;
            cbKhoiLop.SelectedIndexChanged += CbKhoiLop_SelectedIndexChanged;
            cbLop.SelectedIndexChanged += CbLop_SelectedIndexChanged;
        }

        private void CbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocSinhLop();
        }

        private void CbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLop.DataSource = _lop.getList(int.Parse(cbKhoiLop.SelectedValue.ToString()));
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            LoadHocSinhLop();
        }

        private void CbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHocKy.DataSource = _hk.getList(int.Parse(cbNamHoc.SelectedValue.ToString()));
            cbHocKy.DisplayMember = "TENHK";
            cbHocKy.ValueMember = "MAHK";
            LoadHocSinhLop();
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

        void LoadDanhMucLoi()
        {
            lkDanhMucLoi.Properties.DataSource = _vp.getList();
            lkDanhMucLoi.Properties.DisplayMember = "TENLOI";
            lkDanhMucLoi.Properties.ValueMember = "MALOI";
        }

        void LoadHocSinhLop()
        {
            lkHocSinh.Properties.DataSource = _hsl.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()));
            lkHocSinh.Properties.DisplayMember = "HOTEN";
            lkHocSinh.Properties.ValueMember = "MAHS";
        }


        void _showHide(bool kt)
        {
            //btnCapNhat.Enabled = kt;
            //btnDong.Enabled = kt;
            //btnIn.Enabled = kt;
            //cbHocKy.Enabled = !kt;
            //dateNgayVP.Enabled = !kt;
            //cbKhoiLop.Enabled = !kt;
            //cbLop.Enabled = !kt;
            //cbNamHoc.Enabled = !kt;
            //txtGhiChu.Enabled = !kt;
            //lkHocSinh.Enabled = !kt;
            //lkDanhMucLoi.Enabled = !kt;
        }


        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "GIOITINH")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                    e.DisplayText = "Nữ";
                else
                    e.DisplayText = "Nam";

            }
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_them)
            {
                tb_ViPham vp = new tb_ViPham();
                vp.NGAYVP = DateTime.Now;
                vp.GHICHU = txtGhiChu.Text;
                vp.TONGDIEMTRU = int.Parse(gvDanhSach.Columns["DIEM"].SummaryItem.SummaryValue.ToString());
                vp.TONGSOLOI = gvDanhSach.RowCount;
                vp.MALOP = int.Parse(cbLop.SelectedValue.ToString());
                vp.MANH = int.Parse(cbNamHoc.SelectedValue.ToString());
                vp.MAHK = int.Parse(cbHocKy.SelectedValue.ToString());
                vp.CREATEDBY = Commons.UserStatic.UID;
                vp.CREATEDDATE = DateTime.Now;

                var result = _vipham.Add(vp);
                for(int i = 0; i< gvDanhSach.RowCount; i++)
                {
                    tb_ChiTietVP ctvp = new tb_ChiTietVP();
                    ctvp.MAVP = result.MAVP;
                    ctvp.MAHS = int.Parse(gvDanhSach.GetRowCellValue(i, "MAHS").ToString());
                    ctvp.MALOI = int.Parse(gvDanhSach.GetRowCellValue(i, "MALOI").ToString());
                    ctvp.DIEM = int.Parse(gvDanhSach.GetRowCellValue(i, "DIEM").ToString());
                    ctvp.NGAYVP = DateTime.Now;
                    if(gvDanhSach.GetRowCellValue(i, "GHICHU") == null)
                    {
                        ctvp.GHICHU = "";
                    }
                    else
                    {
                        ctvp.GHICHU = gvDanhSach.GetRowCellValue(i, "GHICHU").ToString();
                    }
                    _ctvp.Add(ctvp);
                }
            }
            else
            {

            }
            objForm.getListVP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            vpctDTO ct = new vpctDTO();
            ct.MAHS = int.Parse(lkHocSinh.EditValue.ToString());
            ct.TENHS = lkHocSinh.Text;
            var dr = (tb_DanhMucLoi)lkDanhMucLoi.GetSelectedDataRow();
            ct.MALOI = dr.MALOI;
            ct.TENLOI = dr.TENLOI;
            ct.DIEM = dr.DIEM;
            ct.GHICHU = txtGhiChu.Text;
            ct.NGAYVP = DateTime.Now;
            listCTVP.Add(ct);

            gcDanhSach.DataSource = listCTVP.ToList();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}