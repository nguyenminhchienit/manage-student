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
    public partial class fThongKeViPham : DevExpress.XtraEditors.XtraForm
    {
        public fThongKeViPham()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        THONGKE_VIPHAM _tkvp;
        NAMHOC _namhoc;
        private void fThongKeViPham_Load(object sender, EventArgs e)
        {
            _namhoc = new NAMHOC();
            cbNamHoc.DataSource = _namhoc.getList();
            cbNamHoc.DisplayMember = "TENNH";
            cbNamHoc.ValueMember = "MANH";
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            _tkvp = new THONGKE_VIPHAM();
            gcDanhSach.DataSource = _tkvp.ThongKeViPhamNamHoc(int.Parse(cbNamHoc.SelectedValue.ToString()));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel 2007 or Higher (.xlsx)|*.xlsx";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                gcDanhSach.ExportToXlsx(sf.FileName);
            }
        }
    }
}