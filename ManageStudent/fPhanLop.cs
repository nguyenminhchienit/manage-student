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
using DataAccessLayer;

namespace ManageStudent
{
    public partial class fPhanLop : DevExpress.XtraEditors.XtraForm
    {
        public fPhanLop()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        NAMHOC _nh;
        LOP _lop;
        KHOA _khoi;
        HOCSINH _hs;
        HOCSINH_LOP_NAMHOC _hsl;

        private void fPhanLop_Load(object sender, EventArgs e)
        {
            _nh = new NAMHOC();
            _lop = new LOP();
            _khoi = new KHOA();
            _hs = new HOCSINH();
            _hsl = new HOCSINH_LOP_NAMHOC();
            LoadData();
            LoadHocSinh();
            LoadHSL();

            cbKhoiLop.SelectedIndexChanged += CbKhoiLop_SelectedIndexChanged;
            cbLop.SelectedIndexChanged += CbLop_SelectedIndexChanged;

        }

        private void CbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcHocSinhLop.DataSource = _hsl.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()));
            gvHocSinhLop.OptionsBehavior.Editable = false;
        }

        private void CbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLop.DataSource = _lop.getList(int.Parse(cbKhoiLop.SelectedValue.ToString()));
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        void LoadData()
        {
            cbNamHoc.DataSource = _nh.getList();
            cbNamHoc.DisplayMember = "TENNH";
            cbNamHoc.ValueMember = "MANH";           

            cbKhoiLop.DataSource = _khoi.getList();
            cbKhoiLop.DisplayMember = "TENKHOI";
            cbKhoiLop.ValueMember = "MAKHOI";

            cbLop.DataSource = _lop.getList(int.Parse(cbKhoiLop.SelectedValue.ToString()));
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        void LoadHocSinh()
        {
            gcHocSinh.DataSource = _hs.getListISPHANLOP();
            gvHocSinh.OptionsBehavior.Editable = false;
        }

        void LoadHSL()
        {
            gcHocSinhLop.DataSource = _hsl.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()));
            gvHocSinhLop.OptionsBehavior.Editable = false;
        }

        private void gvHocSinh_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
            for (int i=0;i< gvHocSinh.RowCount; i++){
                if (gvHocSinh.IsRowSelected(i))
                {
                    tb_HS_Lop_NamHoc hs = new tb_HS_Lop_NamHoc();
                    hs.MANH = int.Parse(cbNamHoc.SelectedValue.ToString());
                    hs.MALOP = int.Parse(cbLop.SelectedValue.ToString());
                    hs.MAHS = int.Parse(gvHocSinh.GetRowCellValue(i, "MAHS").ToString());
                    _hsl.Add(hs);
                    gvHocSinh.DeleteRow(i);
                    _hs.UpdateIsPhanLop(hs.MAHS);
                }
            }
            gcHocSinhLop.DataSource = _hsl.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()));
            gvHocSinhLop.OptionsBehavior.Editable = false;
        }

        private void gvHocSinhLop_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "GIOITINHLOP")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                    e.DisplayText = "Nữ";
                else
                    e.DisplayText = "Nam";

            }
        }
    }
}