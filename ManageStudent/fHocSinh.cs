using BusinessLayer;
using DataAccessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using ManageStudent.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent
{
    public partial class fHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public fHocSinh()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        HOCSINH _hs;
        DANTOC _dt;
        TONGIAO _tg;
        int _id = 0;
        int gioitinh = 0;

        private void fHocSinh_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _hs = new HOCSINH();
            _dt = new DANTOC();
            _tg = new TONGIAO();
            LoadDanToc();
            LoadTonGiao();
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
            txtHoTen.Enabled = !kt;
            dateNgaySinh.Enabled = !kt;
            checkGender.Enabled = !kt;
            txtDT.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtEmail.Enabled = !kt;
            cbTonGiao.Enabled = !kt;
            cbDanToc.Enabled = !kt;
            btnPic.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        void saveData()
        {
            if (_them)
            {
                tb_HocSinh _hocsinh = new tb_HocSinh();
                _hocsinh.HOTEN = txtHoTen.Text;
                var index = _hocsinh.HOTEN.LastIndexOf(" ") + 1;
                _hocsinh.TEN = _hocsinh.HOTEN.Substring(index);
                _hocsinh.GIOITINH = gioitinh;
                _hocsinh.NGAYSINH = dateNgaySinh.Value;
                _hocsinh.DT = txtDT.Text;
                _hocsinh.DIACHI = txtDiaChi.Text;
                _hocsinh.EMAIL = txtEmail.Text;
                _hocsinh.GHICHU = txtGhiChu.Text;
                _hocsinh.HINHANH = ImageToBase64(picAvatar.Image, picAvatar.Image.RawFormat);
                _hocsinh.MADT = int.Parse(cbDanToc.SelectedValue.ToString());
                _hocsinh.MATG = int.Parse(cbTonGiao.SelectedValue.ToString());
                _hocsinh.CREATEDBY = Commons.UserStatic.UID;
                _hocsinh.CREATEDDATE = DateTime.Now;
                _hs.Add(_hocsinh);
            }
            else
            {
                tb_HocSinh _hocsinh = _hs.getItem(_id);
                _hocsinh.HOTEN = txtHoTen.Text;
                var index = _hocsinh.HOTEN.LastIndexOf(" ") + 1;
                _hocsinh.TEN = _hocsinh.HOTEN.Substring(index);
                _hocsinh.GIOITINH = gioitinh;
                _hocsinh.NGAYSINH = dateNgaySinh.Value;
                _hocsinh.DT = txtDT.Text;
                _hocsinh.DIACHI = txtDiaChi.Text;
                _hocsinh.EMAIL = txtEmail.Text;
                _hocsinh.GHICHU = txtGhiChu.Text;
                _hocsinh.HINHANH = ImageToBase64(picAvatar.Image, picAvatar.Image.RawFormat);
                _hocsinh.MADT = int.Parse(cbDanToc.SelectedValue.ToString());
                _hocsinh.MATG = int.Parse(cbTonGiao.SelectedValue.ToString());
                _hocsinh.UPDATEDBY = Commons.UserStatic.UID;
                _hocsinh.UPDATEDDATE = DateTime.Now;
                _hs.Update(_hocsinh);
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _hs.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void LoadDanToc()
        {
            cbDanToc.DataSource = _dt.getList();
            cbDanToc.DisplayMember = "TENDT";
            cbDanToc.ValueMember = "MADT";
        }

        void LoadTonGiao()
        {
            cbTonGiao.DataSource = _tg.getList();
            cbTonGiao.DisplayMember = "TENTG";
            cbTonGiao.ValueMember = "MATG";
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
                _hs.Delete(_id, Commons.UserStatic.UID);
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
            HocSinh_report report = new HocSinh_report();
            DocumentViewer documentViewer = new DocumentViewer();
            report.InitData(_hs.getList());
            documentViewer.DocumentSource = report;
            report.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
        

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAHS").ToString());
            var hs = _hs.getItem(_id);
            txtHoTen.Text = hs.HOTEN;
            txtDT.Text = hs.DT;
            txtGhiChu.Text = hs.GHICHU;
            txtDiaChi.Text = hs.DIACHI;
            txtEmail.Text = hs.EMAIL;
            dateNgaySinh.Value = hs.NGAYSINH.Value;
            cbDanToc.SelectedValue = hs.MADT;
            cbTonGiao.SelectedValue = hs.MATG;
            if (hs.GIOITINH == 1)
            {
                checkGender.Checked = true;
            }
            else
            {
                checkGender.Checked = false;
            }
            picAvatar.Image = Base64ToImage(hs.HINHANH);
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETEDBY" && e.CellValue != null)
            {
                Image img = Properties.Resources.Delete_16x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
            if (e.Column.Name == "GIOITINH")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                    e.DisplayText = "Nữ";
                else
                    e.DisplayText = "Nam";

            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(openFile.FileName);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void checkGender_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGender.Checked)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
        }
    }
}