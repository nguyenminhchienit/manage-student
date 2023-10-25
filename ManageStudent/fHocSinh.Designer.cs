
namespace ManageStudent
{
    partial class fHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHocSinh));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbTonGiao = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkGender = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.lbHo = new DevExpress.XtraEditors.LabelControl();
            this.btnPic = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETEDBY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
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
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1634, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1634, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1634, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.picAvatar);
            this.splitContainer1.Panel1.Controls.Add(this.dateNgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.cbTonGiao);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.cbDanToc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.checkGender);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTen);
            this.splitContainer1.Panel1.Controls.Add(this.lbHo);
            this.splitContainer1.Panel1.Controls.Add(this.btnPic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1634, 635);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 7;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(12, 6);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(166, 156);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 19;
            this.picAvatar.TabStop = false;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(316, 62);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(200, 32);
            this.dateNgaySinh.TabIndex = 18;
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.Location = new System.Drawing.Point(808, 110);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(435, 32);
            this.cbTonGiao.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(708, 110);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 24);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Tôn giáo";
            // 
            // cbDanToc
            // 
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Location = new System.Drawing.Point(808, 65);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(435, 32);
            this.cbDanToc.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(717, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Dân tộc";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(808, 15);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 32);
            this.txtEmail.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(737, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(316, 164);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(336, 32);
            this.txtDiaChi.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(228, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 24);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // checkGender
            // 
            this.checkGender.AutoSize = true;
            this.checkGender.Location = new System.Drawing.Point(575, 64);
            this.checkGender.Name = "checkGender";
            this.checkGender.Size = new System.Drawing.Size(77, 28);
            this.checkGender.TabIndex = 8;
            this.checkGender.Text = "Nam";
            this.checkGender.UseVisualStyleBackColor = true;
            this.checkGender.CheckedChanged += new System.EventHandler(this.checkGender_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(202, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ngày sinh";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(316, 106);
            this.txtDT.MenuManager = this.barManager1;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(336, 32);
            this.txtDT.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(197, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Điện thoại";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(316, 15);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(336, 32);
            this.txtHoTen.TabIndex = 3;
            // 
            // lbHo
            // 
            this.lbHo.Location = new System.Drawing.Point(229, 19);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(60, 24);
            this.lbHo.TabIndex = 2;
            this.lbHo.Text = "Họ tên";
            // 
            // btnPic
            // 
            this.btnPic.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPic.ImageOptions.SvgImage")));
            this.btnPic.Location = new System.Drawing.Point(12, 168);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(166, 45);
            this.btnPic.TabIndex = 1;
            this.btnPic.Text = "Chọn ảnh";
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.EmbeddedNavigator.UseWaitCursor = true;
            this.gcDanhSach.Location = new System.Drawing.Point(3, 3);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1630, 405);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.UseWaitCursor = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach,
            this.gridView1});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHS,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.TENDT,
            this.TENTG,
            this.DT,
            this.EMAIL,
            this.DIACHI,
            this.HINHANH,
            this.GHICHU,
            this.DELETEDBY});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MAHS
            // 
            this.MAHS.Caption = "MÃ HS";
            this.MAHS.FieldName = "MAHS";
            this.MAHS.MaxWidth = 80;
            this.MAHS.MinWidth = 80;
            this.MAHS.Name = "MAHS";
            this.MAHS.Visible = true;
            this.MAHS.VisibleIndex = 0;
            this.MAHS.Width = 80;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 200;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AppearanceCell.Options.UseTextOptions = true;
            this.GIOITINH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.GIOITINH.Caption = "GIỚI TÍNH";
            this.GIOITINH.FieldName = "GIOITINH";
            this.GIOITINH.MaxWidth = 150;
            this.GIOITINH.MinWidth = 150;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 2;
            this.GIOITINH.Width = 150;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Caption = "NGÀY SINH";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.MaxWidth = 150;
            this.NGAYSINH.MinWidth = 150;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 3;
            this.NGAYSINH.Width = 150;
            // 
            // TENDT
            // 
            this.TENDT.Caption = "DÂN TỘC";
            this.TENDT.FieldName = "TENDT";
            this.TENDT.MaxWidth = 100;
            this.TENDT.MinWidth = 100;
            this.TENDT.Name = "TENDT";
            this.TENDT.Visible = true;
            this.TENDT.VisibleIndex = 4;
            this.TENDT.Width = 100;
            // 
            // TENTG
            // 
            this.TENTG.Caption = "TÔN GIÁO";
            this.TENTG.FieldName = "TENTG";
            this.TENTG.MaxWidth = 100;
            this.TENTG.MinWidth = 100;
            this.TENTG.Name = "TENTG";
            this.TENTG.Visible = true;
            this.TENTG.VisibleIndex = 5;
            this.TENTG.Width = 100;
            // 
            // DT
            // 
            this.DT.Caption = "ĐIỆN THOẠI";
            this.DT.FieldName = "DT";
            this.DT.MaxWidth = 150;
            this.DT.MinWidth = 150;
            this.DT.Name = "DT";
            this.DT.Visible = true;
            this.DT.VisibleIndex = 6;
            this.DT.Width = 150;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "EMAIL";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.MaxWidth = 100;
            this.EMAIL.MinWidth = 100;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 7;
            this.EMAIL.Width = 100;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MaxWidth = 150;
            this.DIACHI.MinWidth = 150;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 8;
            this.DIACHI.Width = 150;
            // 
            // HINHANH
            // 
            this.HINHANH.Caption = "HÌNH ẢNH";
            this.HINHANH.FieldName = "HINHANH";
            this.HINHANH.MaxWidth = 150;
            this.HINHANH.MinWidth = 150;
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.Visible = true;
            this.HINHANH.VisibleIndex = 9;
            this.HINHANH.Width = 150;
            // 
            // DELETEDBY
            // 
            this.DELETEDBY.FieldName = "DELETEDBY";
            this.DELETEDBY.MaxWidth = 27;
            this.DELETEDBY.MinWidth = 27;
            this.DELETEDBY.Name = "DELETEDBY";
            this.DELETEDBY.Visible = true;
            this.DELETEDBY.VisibleIndex = 11;
            this.DELETEDBY.Width = 27;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(808, 164);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(435, 32);
            this.txtGhiChu.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(720, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 24);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Ghi chú";
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 200;
            this.GHICHU.MinWidth = 200;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 10;
            this.GHICHU.Width = 200;
            // 
            // fHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 671);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fHocSinh";
            this.Text = "Học sinh";
            this.Load += new System.EventHandler(this.fHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox cbTonGiao;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbDanToc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.CheckBox checkGender;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl lbHo;
        private DevExpress.XtraEditors.SimpleButton btnPic;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MAHS;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn TENDT;
        private DevExpress.XtraGrid.Columns.GridColumn TENTG;
        private DevExpress.XtraGrid.Columns.GridColumn DT;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn HINHANH;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn DELETEDBY;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}