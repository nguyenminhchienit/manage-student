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
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
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

        void LoadHocSinhLop()
        {
            lkHocSinh.Properties.DataSource = _hsl.getList(int.Parse(cbNamHoc.SelectedValue.ToString()), int.Parse(cbLop.SelectedValue.ToString()));
            lkHocSinh.Properties.DisplayMember = "HOTEN";
            lkHocSinh.Properties.ValueMember = "MAHS";
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

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            _hk = new HOCKY();
            _nh = new NAMHOC();
            _lop = new LOP();
            _hs = new HOCSINH();
            _khoi = new KHOA();
            _hsl = new HOCSINH_LOP_NAMHOC();

            LoadData();
            LoadHocSinhLop();

            cbNamHoc.SelectedIndexChanged += CbNamHoc_SelectedIndexChanged;
            cbKhoiLop.SelectedIndexChanged += CbKhoiLop_SelectedIndexChanged;
            cbLop.SelectedIndexChanged += CbLop_SelectedIndexChanged;
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            if(lkHocSinh.EditValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh cần nhập điểm", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            tb_HocSinh hs = _hs.getItem(int.Parse(lkHocSinh.EditValue.ToString()));
            if(hs != null)
            {
                hs.DIEMHOA = float.Parse(txtHoa.Text);
                hs.DIEMLY = float.Parse(txtLy.Text);
                hs.DIEMTOAN = float.Parse(txtToan.Text);
                float dh = float.Parse(txtHoa.Text);
                float dt = float.Parse(txtToan.Text);
                float dl = float.Parse(txtLy.Text);
                hs.DTB = Math.Round(float.Parse(((dt + dl + dh) / 3).ToString()),1);
                _hs.Update(hs);
                MessageBox.Show("Cập nhật điểm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Học sinh không tồn tại","Thông báo",MessageBoxButtons.OK);
            }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = _hs.getListDiem(int.Parse(cbLop.SelectedValue.ToString()));
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        int _id = 0;
        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAHS").ToString());
            var hs = _hs.getItem(_id);
            txtToan.Text = hs.DIEMTOAN.ToString();
            txtLy.Text = hs.DIEMLY.ToString();
            txtHoa.Text = hs.DIEMHOA.ToString();
            lkHocSinh.EditValue = hs.MAHS;
        }

        private void txtToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa được nhấn có phải là số hoặc dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Đảm bảo chỉ có một dấu chấm được phép
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ngăn không cho thêm dấu chấm
            }
        }

        private void txtLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa được nhấn có phải là số hoặc dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Đảm bảo chỉ có một dấu chấm được phép
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ngăn không cho thêm dấu chấm
            }
        }

        private void txtHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa được nhấn có phải là số hoặc dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }

            // Đảm bảo chỉ có một dấu chấm được phép
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ngăn không cho thêm dấu chấm
            }
        }
    }
}
