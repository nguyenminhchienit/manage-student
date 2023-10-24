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
    public partial class fGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public fGiaoVien()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        GIAOVIEN _gv;
        TRINHDO _td;
        CHUCVU _cv;
        int _id = 0;
        int gioitinh = 0;

        private void fGiaoVien_Load(object sender, EventArgs e)
        {
            //_showHide(true);
            _gv = new GIAOVIEN();
            _td = new TRINHDO();
            _cv = new CHUCVU();

            CheckPermission();

            LoadChucVu();
            LoadTrinhDo();
            LoadData();
            
        }

        public void CheckPermission()
        {
            if (Commons.UserStatic != null)
            {
                if (Commons.UserStatic.ROLE == "Admin")
                {
                    _showHide(true);
                }
                else
                {
                    bar3.Visible = false;
                    txtHoTen.Enabled = false;
                    dateNgaySinh.Enabled = false;
                    checkGender.Enabled = false;
                    txtDT.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtEmail.Enabled = false;
                    btnPic.Enabled = false;
                    cbChucVu.Enabled = false;
                    cbTrinhDo.Enabled = false;
                }

            }
            else
            {
                this.Close();
            }

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
            cbChucVu.Enabled = !kt;
            cbTrinhDo.Enabled = !kt;
            btnPic.Enabled = !kt;
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream()){
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
                tb_GiaoVien _giaovien = new tb_GiaoVien();
                _giaovien.HOTEN = txtHoTen.Text;
                var index = _giaovien.HOTEN.LastIndexOf(" ") + 1;
                _giaovien.TEN = _giaovien.HOTEN.Substring(index);
                _giaovien.GIOITINH = gioitinh;
                _giaovien.NGAYSINH = dateNgaySinh.Value;
                _giaovien.DT = txtDT.Text;
                _giaovien.DIACHI = txtDiaChi.Text;
                _giaovien.EMAIL = txtEmail.Text;
                _giaovien.HINHANH = ImageToBase64(picAvatar.Image, picAvatar.Image.RawFormat);
                _giaovien.MACV = int.Parse(cbChucVu.SelectedValue.ToString());
                _giaovien.MATD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                _giaovien.CREATEDBY = Commons.UserStatic.UID;
                _giaovien.CREATEDDATE = DateTime.Now;
                _gv.Add(_giaovien);
            }
            else
            {
                tb_GiaoVien _giaovien = _gv.getItem(_id);
                _giaovien.HOTEN = txtHoTen.Text;
                var index = _giaovien.HOTEN.LastIndexOf(" ") + 1;
                _giaovien.TEN = _giaovien.HOTEN.Substring(index);
                _giaovien.GIOITINH = gioitinh;
                _giaovien.NGAYSINH = dateNgaySinh.Value;
                _giaovien.DT = txtDT.Text;
                _giaovien.DIACHI = txtDiaChi.Text;
                _giaovien.EMAIL = txtEmail.Text;
                _giaovien.HINHANH = ImageToBase64(picAvatar.Image, picAvatar.Image.RawFormat);
                _giaovien.MACV = int.Parse(cbChucVu.SelectedValue.ToString());
                _giaovien.MATD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                _giaovien.UPDATEDBY = Commons.UserStatic.UID;
                _giaovien.UPDATEDDATE = DateTime.Now;
                _gv.Update(_giaovien);
            }
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _gv.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void LoadTrinhDo()
        {
            cbTrinhDo.DataSource = _td.getList();
            cbTrinhDo.DisplayMember = "TENTD";
            cbTrinhDo.ValueMember = "MATD";
        }

        void LoadChucVu()
        {
            cbChucVu.DataSource = _cv.getList();
            cbChucVu.DisplayMember = "TENCV";
            cbChucVu.ValueMember = "MACV";
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
                _gv.Delete(_id, Commons.UserStatic.UID);
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
            GiaoVien_report report = new GiaoVien_report();
            DocumentViewer documentViewer = new DocumentViewer();
            report.InitData(_gv.getList());
            documentViewer.DocumentSource = report;
            report.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                if(int.Parse(e.CellValue.ToString()) == 0)
                    e.DisplayText = "Nữ";
                else
                    e.DisplayText = "Nam";
                
            }
            
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAGV").ToString());
            var gv = _gv.getItem(_id);
            txtHoTen.Text = gv.HOTEN;
            txtDT.Text = gv.DT;
            txtDiaChi.Text = gv.DIACHI;
            txtEmail.Text = gv.EMAIL;
            dateNgaySinh.Value = gv.NGAYSINH.Value;
            cbChucVu.SelectedValue = gv.MACV;
            cbTrinhDo.SelectedValue = gv.MATD;
            if(gv.GIOITINH == 1)
            {
                checkGender.Checked = true;
            }
            else
            {
                checkGender.Checked = false;
            }
            picAvatar.Image = Base64ToImage(gv.HINHANH);
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(openFile.FileName);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}