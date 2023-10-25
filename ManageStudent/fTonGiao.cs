using BusinessLayer;
using DataAccessLayer;
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
    public partial class fTonGiao : Form
    {
        public fTonGiao()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool _them;
        TONGIAO _tg;
        int _id = 0;

        private void fTonGiao_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _tg = new TONGIAO();
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
            txtTonGiao.Enabled = !kt;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _tg.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
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
                _tg.Delete(_id, Commons.UserStatic.UID);
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

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            if (_them)
            {
                tb_TonGiao _tongiao = new tb_TonGiao();
                _tongiao.TENTG = txtTonGiao.Text;
                _tongiao.CREATEDBY = Commons.UserStatic.UID;
                _tongiao.CREATEDDATE = DateTime.Now;
                _tg.Add(_tongiao);
            }
            else
            {
                tb_TonGiao _tongiao = _tg.getItem(_id);
                _tongiao.TENTG = txtTonGiao.Text;
                _tongiao.UPDATEDBY = Commons.UserStatic.UID;
                _tongiao.UPDATEDDATE = DateTime.Now;
                _tg.Update(_tongiao);
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MATG").ToString());
                txtTonGiao.Text = (gvDanhSach.GetFocusedRowCellValue("TENTG").ToString());
            }
        }
    }
}
