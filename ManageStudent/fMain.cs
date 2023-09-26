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
            Commons.handle =  ShowProgressPanel(this, options);
            fLogin login = new fLogin();
            login.ShowDialog();

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
    }
}