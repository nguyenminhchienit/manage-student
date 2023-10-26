using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
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
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        OverlayWindowOptions options = new OverlayWindowOptions(
            backColor: Color.Black,
            opacity: 0.5,
            fadeIn: false,
            fadeOut: false
        );

        IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions options)
        {
            return SplashScreenManager.ShowOverlayForm(control,options);
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            barButtonItem1.Enabled = false;
            mnBackup.Enabled = false;
            mnRestore.Enabled = false;
            ribonChucNang.Visible = false;
            ribonThongKe.Visible = false;
            mnGiaovien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            mnViPham.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            mnTrinhDo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            mnChucVu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ribbonPageGroup6.Visible = false;
            ribbonPageGroup7.Visible = false;
            ribbonPageGroup8.Visible = false;
            ribonTaiKhoan.Visible = false;

            Commons.handle =  ShowProgressPanel(this, options);
            fLogin login = new fLogin();
            login.ShowDialog();
            CheckPermission();
        }

        void openForm(Type typeForm)
        {
            foreach(var fr in MdiChildren)
            {
                if(fr.GetType() == typeForm)
                {
                    fr.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void mnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fMonHoc));
        }

        private void mnNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fNamHoc));
        }

        private void mnGiaovien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fGiaoVien));
        }

        private void mnViPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fDanhMucLoi));
        }

        private void mnHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fHocKy));
        }

        private void mnHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fHocSinh));
        }

        private void mnQLVP_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fDanhMucViPham));
        }

        private void btnPhanLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fPhanLop));
        }

        private void mnTKTheoNam_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fThongKeViPham));
        }

        private void mnQLDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fQuanLyDiem));
        }

        public void CheckPermission()
        {
            if(Commons.UserStatic != null)
            {
                if (Commons.UserStatic.ROLE == "Admin")
                {
                    barButtonItem1.Enabled = true;
                    mnBackup.Enabled = true;
                    mnRestore.Enabled = true;
                    ribonChucNang.Visible = true;
                    ribonThongKe.Visible = true;
                    mnGiaovien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    mnViPham.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    mnTrinhDo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    mnChucVu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ribbonPageGroup6.Visible = true;
                    ribbonPageGroup7.Visible = true;
                    ribbonPageGroup8.Visible = true;
                    ribonTaiKhoan.Visible = true;
                }
                else if(Commons.UserStatic.ROLE == "Giáo Viên")
                {
                    ribonChucNang.Visible = true;
                    ribonThongKe.Visible = true;
                    mnGiaovien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    mnViPham.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    ribbonPageGroup6.Visible = true;
                    ribbonPageGroup7.Visible = true;
                }
            }
            else
            {
                this.Close();
            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Commons.UserStatic.ROLE == "Admin")
            {
                fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            f.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fXemDiem));
        }

        private void mnQLHocLuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fHocLuc));
        }

        private void mnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fTonGiao));
        }

        private void mnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fDanToc));
        }

        private void mnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fKhoiLop));
        }

        private void mnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fLop));
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(fTaiKhoan));
        }
    }
}