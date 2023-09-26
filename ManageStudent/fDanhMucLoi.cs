using BusinessLayer;
using DataAccessLayer;
using DevExpress.DataAccess.Excel;
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
    public partial class fDanhMucLoi : DevExpress.XtraEditors.XtraForm
    {
        public fDanhMucLoi()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        DANHMUCLOI _dml;
        int _id = 0;
        bool _import = false;

        private void fDanhMucLoi_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _dml = new DANHMUCLOI();
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
            txtViPham.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            spinDiemTru.Enabled = !kt;
            chkNghiemTrong.Enabled = !kt;
            btnExcel.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            btnExcel.Enabled = true;
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
                _dml.Delete(_id, Commons.UserStatic.UID);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_import)
            {
                saveExcel();
                _import = false;
            }
            else
            {
                saveData();
            }            
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

        void saveExcel()
        {
            for(var i = 0; i< gvDanhSach.RowCount; i++)
            {
                tb_DanhMucLoi _dmloi = new tb_DanhMucLoi();
                _dmloi.TENLOI = gvDanhSach.GetRowCellValue(i,"TENLOI").ToString();

                if(gvDanhSach.GetRowCellValue(i, "GHICHU") == null)
                {
                    _dmloi.GHICHU = "";
                }
                else
                {
                    _dmloi.GHICHU = gvDanhSach.GetRowCellValue(i, "GHICHU").ToString();
                }

                _dmloi.DIEM = int.Parse(gvDanhSach.GetRowCellValue(i, "DIEM").ToString());
                _dmloi.NGHIEMTRONG = bool.Parse(gvDanhSach.GetRowCellValue(i, "NGHIEMTRONG").ToString());
                _dmloi.CREATEDBY = Commons.UserStatic.UID;
                _dmloi.CREATEDDATE = DateTime.Now;
                _dml.Add(_dmloi);
            }
        }

        void saveData()
        {
            if (_them)
            {
                tb_DanhMucLoi _dmloi = new tb_DanhMucLoi();
                _dmloi.TENLOI = txtViPham.Text;
                _dmloi.GHICHU = txtGhiChu.Text;
                _dmloi.DIEM = int.Parse(spinDiemTru.EditValue.ToString());
                _dmloi.NGHIEMTRONG = chkNghiemTrong.Checked;
                _dmloi.CREATEDBY = Commons.UserStatic.UID;
                _dmloi.CREATEDDATE = DateTime.Now;
                _dml.Add(_dmloi);
            }
            else
            {
                tb_DanhMucLoi _dmloi = _dml.getItem(_id);
                _dmloi.TENLOI = txtViPham.Text;
                _dmloi.GHICHU = txtGhiChu.Text;
                _dmloi.DIEM = int.Parse(spinDiemTru.EditValue.ToString());
                _dmloi.NGHIEMTRONG = chkNghiemTrong.Checked;
                _dmloi.UPDATEDBY = Commons.UserStatic.UID;
                _dmloi.UPDATEDDATE = DateTime.Now;
                _dml.Update(_dmloi);
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _dml.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
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

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MALOI").ToString());
                txtViPham.Text = (gvDanhSach.GetFocusedRowCellValue("TENLOI").ToString());
                txtGhiChu.Text = (gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString());
                spinDiemTru.EditValue = (gvDanhSach.GetFocusedRowCellValue("DIEM").ToString());
                chkNghiemTrong.Checked = bool.Parse((gvDanhSach.GetFocusedRowCellValue("NGHIEMTRONG").ToString()));
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Chọn file ";
            fd.Filter = "Excel (*.xlsx) |*.xlsx";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = fd.FileName;
                ExcelWorksheetSettings excelWork = new ExcelWorksheetSettings("Sheet1","A1:E100");
                excel.SourceOptions = new ExcelSourceOptions(excelWork);
                excel.SourceOptions = new CsvSourceOptions() { CellRange= "A1:E100" };
                excel.SourceOptions.SkipEmptyRows = false;
                excel.SourceOptions.UseFirstRowAsHeader = true;
                excel.Fill();
                gcDanhSach.DataSource = excel;
                _import = true;
            }
      
        }
    }
}