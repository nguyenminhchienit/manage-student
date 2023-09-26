
namespace ManageStudent
{
    partial class fQuanLyViPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyViPham));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lkHocSinh = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkDanhMucLoi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGHIEMTRONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbKhoiLop = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayVP = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbHo = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MALOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOICT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETEDBY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucLoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapNhat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 0;
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
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
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1353, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 666);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1353, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 630);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1353, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 630);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.lkHocSinh);
            this.splitContainer1.Panel1.Controls.Add(this.lkDanhMucLoi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.cbLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.cbKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cbHocKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.cbNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.dateNgayVP);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.lbHo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1353, 630);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(1010, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 52);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lkHocSinh
            // 
            this.lkHocSinh.EditValue = "Chọn học sinh";
            this.lkHocSinh.Location = new System.Drawing.Point(686, 61);
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
            // lkDanhMucLoi
            // 
            this.lkDanhMucLoi.EditValue = "Chọn lỗi vi phạm";
            this.lkDanhMucLoi.Location = new System.Drawing.Point(686, 106);
            this.lkDanhMucLoi.MenuManager = this.barManager1;
            this.lkDanhMucLoi.Name = "lkDanhMucLoi";
            this.lkDanhMucLoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDanhMucLoi.Properties.PopupView = this.gridView2;
            this.lkDanhMucLoi.Size = new System.Drawing.Size(435, 32);
            this.lkDanhMucLoi.TabIndex = 31;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NGHIEMTRONG,
            this.TENLOI});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // NGHIEMTRONG
            // 
            this.NGHIEMTRONG.Caption = "NGHIÊM TRỌNG";
            this.NGHIEMTRONG.FieldName = "NGHIEMTRONG";
            this.NGHIEMTRONG.Name = "NGHIEMTRONG";
            this.NGHIEMTRONG.Visible = true;
            this.NGHIEMTRONG.VisibleIndex = 0;
            // 
            // TENLOI
            // 
            this.TENLOI.Caption = "TÊN LỖI";
            this.TENLOI.FieldName = "TENLOI";
            this.TENLOI.Name = "TENLOI";
            this.TENLOI.Visible = true;
            this.TENLOI.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(542, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 24);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Danh mục lỗi";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(147, 159);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(339, 32);
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
            this.cbKhoiLop.Size = new System.Drawing.Size(339, 32);
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
            this.cbHocKy.Size = new System.Drawing.Size(339, 32);
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
            this.cbNamHoc.Size = new System.Drawing.Size(339, 32);
            this.cbNamHoc.TabIndex = 22;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(686, 159);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(435, 32);
            this.txtGhiChu.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(542, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 24);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Ghi chú";
            // 
            // dateNgayVP
            // 
            this.dateNgayVP.CustomFormat = "dd-MM-yyyy";
            this.dateNgayVP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayVP.Location = new System.Drawing.Point(686, 18);
            this.dateNgayVP.Name = "dateNgayVP";
            this.dateNgayVP.Size = new System.Drawing.Size(200, 32);
            this.dateNgayVP.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(542, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Học sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(542, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ngày";
            // 
            // lbHo
            // 
            this.lbHo.Location = new System.Drawing.Point(51, 18);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(78, 24);
            this.lbHo.TabIndex = 2;
            this.lbHo.Text = "Năm học";
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
            this.MALOI,
            this.TENHS,
            this.TENLOICT,
            this.DIEM,
            this.GHICHU,
            this.DELETEDBY});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowFooter = true;
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            // 
            // MALOI
            // 
            this.MALOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MALOI.AppearanceHeader.Options.UseFont = true;
            this.MALOI.Caption = "ID";
            this.MALOI.FieldName = "MALOI";
            this.MALOI.MaxWidth = 50;
            this.MALOI.MinWidth = 50;
            this.MALOI.Name = "MALOI";
            this.MALOI.Visible = true;
            this.MALOI.VisibleIndex = 0;
            this.MALOI.Width = 50;
            // 
            // TENHS
            // 
            this.TENHS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TENHS.AppearanceHeader.Options.UseFont = true;
            this.TENHS.Caption = "HỌ TÊN";
            this.TENHS.FieldName = "TENHS";
            this.TENHS.MaxWidth = 300;
            this.TENHS.MinWidth = 300;
            this.TENHS.Name = "TENHS";
            this.TENHS.Visible = true;
            this.TENHS.VisibleIndex = 1;
            this.TENHS.Width = 300;
            // 
            // TENLOICT
            // 
            this.TENLOICT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TENLOICT.AppearanceHeader.Options.UseFont = true;
            this.TENLOICT.Caption = "TÊN LỖI";
            this.TENLOICT.FieldName = "TENLOI";
            this.TENLOICT.MaxWidth = 300;
            this.TENLOICT.MinWidth = 300;
            this.TENLOICT.Name = "TENLOICT";
            this.TENLOICT.Visible = true;
            this.TENLOICT.VisibleIndex = 2;
            this.TENLOICT.Width = 300;
            // 
            // DIEM
            // 
            this.DIEM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DIEM.AppearanceHeader.Options.UseFont = true;
            this.DIEM.Caption = "ĐIỂM ";
            this.DIEM.FieldName = "DIEM";
            this.DIEM.MaxWidth = 100;
            this.DIEM.MinWidth = 100;
            this.DIEM.Name = "DIEM";
            this.DIEM.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DIEM", "{0:n0}")});
            this.DIEM.Visible = true;
            this.DIEM.VisibleIndex = 3;
            this.DIEM.Width = 100;
            // 
            // GHICHU
            // 
            this.GHICHU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.GHICHU.AppearanceHeader.Options.UseFont = true;
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 200;
            this.GHICHU.MinWidth = 200;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 4;
            this.GHICHU.Width = 200;
            // 
            // DELETEDBY
            // 
            this.DELETEDBY.FieldName = "DELETEDBY";
            this.DELETEDBY.MaxWidth = 27;
            this.DELETEDBY.MinWidth = 27;
            this.DELETEDBY.Name = "DELETEDBY";
            this.DELETEDBY.Visible = true;
            this.DELETEDBY.VisibleIndex = 5;
            this.DELETEDBY.Width = 27;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // fQuanLyViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 666);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fQuanLyViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vi phạm";
            this.Load += new System.EventHandler(this.fQuanLyViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDanhMucLoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SearchLookUpEdit lkDanhMucLoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbKhoiLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DateTimePicker dateNgayVP;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbHo;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MALOI;
        private DevExpress.XtraGrid.Columns.GridColumn TENHS;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOICT;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn DELETEDBY;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit lkHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn NGHIEMTRONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOI;
        private DevExpress.XtraGrid.Columns.GridColumn MAHS;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}