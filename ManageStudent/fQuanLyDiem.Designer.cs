
namespace ManageStudent
{
    partial class fQuanLyDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyDiem));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHOCSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMLY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhatDiem = new DevExpress.XtraEditors.SimpleButton();
            this.lkHocSinh = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbKhoiLop = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbHo = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.btnXemDiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.EmbeddedNavigator.UseWaitCursor = true;
            this.gcDanhSach.Location = new System.Drawing.Point(3, 3);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1350, 405);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.UseWaitCursor = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach,
            this.gridView1});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHOCSINH,
            this.HOTEN,
            this.DIEMTOAN,
            this.DIEMLY,
            this.DIEMHOA,
            this.DTB});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowFooter = true;
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // MAHOCSINH
            // 
            this.MAHOCSINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MAHOCSINH.AppearanceHeader.Options.UseFont = true;
            this.MAHOCSINH.Caption = "ID";
            this.MAHOCSINH.FieldName = "MAHS";
            this.MAHOCSINH.MaxWidth = 100;
            this.MAHOCSINH.MinWidth = 50;
            this.MAHOCSINH.Name = "MAHOCSINH";
            this.MAHOCSINH.Visible = true;
            this.MAHOCSINH.VisibleIndex = 0;
            this.MAHOCSINH.Width = 100;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 300;
            this.HOTEN.MinWidth = 300;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 300;
            // 
            // DIEMTOAN
            // 
            this.DIEMTOAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DIEMTOAN.AppearanceHeader.Options.UseFont = true;
            this.DIEMTOAN.Caption = "ĐIỂM TOÁN";
            this.DIEMTOAN.FieldName = "DIEMTOAN";
            this.DIEMTOAN.MaxWidth = 150;
            this.DIEMTOAN.MinWidth = 100;
            this.DIEMTOAN.Name = "DIEMTOAN";
            this.DIEMTOAN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DIEM", "{0:n0}")});
            this.DIEMTOAN.Visible = true;
            this.DIEMTOAN.VisibleIndex = 2;
            this.DIEMTOAN.Width = 150;
            // 
            // DIEMLY
            // 
            this.DIEMLY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DIEMLY.AppearanceHeader.Options.UseFont = true;
            this.DIEMLY.Caption = "ĐIỂM LÝ";
            this.DIEMLY.FieldName = "DIEMLY";
            this.DIEMLY.MaxWidth = 150;
            this.DIEMLY.MinWidth = 100;
            this.DIEMLY.Name = "DIEMLY";
            this.DIEMLY.Visible = true;
            this.DIEMLY.VisibleIndex = 3;
            this.DIEMLY.Width = 150;
            // 
            // DIEMHOA
            // 
            this.DIEMHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DIEMHOA.AppearanceHeader.Options.UseFont = true;
            this.DIEMHOA.Caption = "ĐIỂM HÓA";
            this.DIEMHOA.FieldName = "DIEMHOA";
            this.DIEMHOA.MaxWidth = 150;
            this.DIEMHOA.MinWidth = 100;
            this.DIEMHOA.Name = "DIEMHOA";
            this.DIEMHOA.Visible = true;
            this.DIEMHOA.VisibleIndex = 4;
            this.DIEMHOA.Width = 150;
            // 
            // DTB
            // 
            this.DTB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DTB.AppearanceHeader.Options.UseFont = true;
            this.DTB.Caption = "ĐIỂM TRUNG BÌNH";
            this.DTB.FieldName = "DTB";
            this.DTB.MaxWidth = 300;
            this.DTB.MinWidth = 200;
            this.DTB.Name = "DTB";
            this.DTB.Visible = true;
            this.DTB.VisibleIndex = 5;
            this.DTB.Width = 300;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCapNhat,
            this.btnXoa,
            this.btnIn,
            this.btnDong});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(177, 284);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 5;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.Image = global::ManageStudent.Properties.Resources.Delete_16x16;
            this.btnDong.Name = "btnDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1359, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 679);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1359, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 643);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1359, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 643);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 0;
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatDiem.ImageOptions.SvgImage")));
            this.btnCapNhatDiem.Location = new System.Drawing.Point(1099, 61);
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.Size = new System.Drawing.Size(150, 52);
            this.btnCapNhatDiem.TabIndex = 33;
            this.btnCapNhatDiem.Text = "Cập nhật";
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // lkHocSinh
            // 
            this.lkHocSinh.EditValue = "";
            this.lkHocSinh.Location = new System.Drawing.Point(804, 13);
            this.lkHocSinh.MenuManager = this.barManager1;
            this.lkHocSinh.Name = "lkHocSinh";
            this.lkHocSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkHocSinh.Properties.PopupView = this.gridView3;
            this.lkHocSinh.Size = new System.Drawing.Size(435, 32);
            this.lkHocSinh.TabIndex = 32;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHS,
            this.HOTENLOP,
            this.TENLOP});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // MAHS
            // 
            this.MAHS.Caption = "ID";
            this.MAHS.FieldName = "MAHS";
            this.MAHS.Name = "MAHS";
            this.MAHS.Visible = true;
            this.MAHS.VisibleIndex = 0;
            // 
            // HOTENLOP
            // 
            this.HOTENLOP.Caption = "HỌ TÊN";
            this.HOTENLOP.FieldName = "HOTEN";
            this.HOTENLOP.Name = "HOTENLOP";
            this.HOTENLOP.Visible = true;
            this.HOTENLOP.VisibleIndex = 1;
            // 
            // TENLOP
            // 
            this.TENLOP.Caption = "LỚP";
            this.TENLOP.FieldName = "TENLOP";
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Visible = true;
            this.TENLOP.VisibleIndex = 2;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(147, 159);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(339, 28);
            this.cbLop.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 24);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Lớp";
            // 
            // cbKhoiLop
            // 
            this.cbKhoiLop.FormattingEnabled = true;
            this.cbKhoiLop.Location = new System.Drawing.Point(147, 106);
            this.cbKhoiLop.Name = "cbKhoiLop";
            this.cbKhoiLop.Size = new System.Drawing.Size(339, 28);
            this.cbKhoiLop.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 24);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Khối lớp";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(147, 61);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(339, 28);
            this.cbHocKy.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(51, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 24);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Học kỳ";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(147, 15);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(339, 28);
            this.cbNamHoc.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(660, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Học sinh";
            // 
            // lbHo
            // 
            this.lbHo.Location = new System.Drawing.Point(51, 18);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(78, 24);
            this.lbHo.TabIndex = 2;
            this.lbHo.Text = "Năm học";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtHoa);
            this.splitContainer1.Panel1.Controls.Add(this.txtLy);
            this.splitContainer1.Panel1.Controls.Add(this.txtToan);
            this.splitContainer1.Panel1.Controls.Add(this.btnXemDiem);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCapNhatDiem);
            this.splitContainer1.Panel1.Controls.Add(this.lkHocSinh);
            this.splitContainer1.Panel1.Controls.Add(this.cbLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.cbKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cbHocKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.cbNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.lbHo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1359, 643);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 9;
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(908, 155);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(150, 26);
            this.txtHoa.TabIndex = 43;
            this.txtHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoa_KeyPress);
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(908, 108);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(150, 26);
            this.txtLy.TabIndex = 42;
            this.txtLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLy_KeyPress);
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(908, 65);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(150, 26);
            this.txtToan.TabIndex = 41;
            this.txtToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToan_KeyPress);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemDiem.ImageOptions.SvgImage")));
            this.btnXemDiem.Location = new System.Drawing.Point(1099, 129);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(150, 52);
            this.btnXemDiem.TabIndex = 40;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(811, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 24);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Điểm hóa";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(811, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 24);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Điểm toán";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(811, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 24);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Điểm lý";
            // 
            // fQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 679);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fQuanLyDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.fQuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MAHOCSINH;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMLY;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMHOA;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDiem;
        private DevExpress.XtraEditors.SearchLookUpEdit lkHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn MAHS;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private System.Windows.Forms.ComboBox cbLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbKhoiLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbHo;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXemDiem;
        private DevExpress.XtraGrid.Columns.GridColumn DTB;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.TextBox txtLy;
    }
}