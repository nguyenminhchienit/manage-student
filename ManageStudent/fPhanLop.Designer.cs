
namespace ManageStudent
{
    partial class fPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbKhoiLop = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.lbHo = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcHocSinh = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHocSinhLop = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinhLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHSLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINHLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHILOP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCapNhat,
            this.btnSave,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnIn,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapNhat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 0;
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1349, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1349, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1349, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 5;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
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
            this.splitContainer1.Panel1.Controls.Add(this.cbLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.cbKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cbNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.lbHo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1349, 655);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 9;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(973, 13);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(339, 32);
            this.cbLop.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(897, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 24);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Lớp";
            // 
            // cbKhoiLop
            // 
            this.cbKhoiLop.FormattingEnabled = true;
            this.cbKhoiLop.Location = new System.Drawing.Point(535, 13);
            this.cbKhoiLop.Name = "cbKhoiLop";
            this.cbKhoiLop.Size = new System.Drawing.Size(339, 32);
            this.cbKhoiLop.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(439, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 24);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Khối lớp";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(147, 15);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(254, 32);
            this.cbNamHoc.TabIndex = 22;
            // 
            // lbHo
            // 
            this.lbHo.Location = new System.Drawing.Point(51, 18);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(78, 24);
            this.lbHo.TabIndex = 2;
            this.lbHo.Text = "Năm học";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcHocSinh);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcHocSinhLop);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1349, 586);
            this.splitContainerControl1.SplitterPosition = 627;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gcHocSinh
            // 
            this.gcHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocSinh.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinh.MainView = this.gvHocSinh;
            this.gcHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocSinh.MenuManager = this.barManager1;
            this.gcHocSinh.Name = "gcHocSinh";
            this.gcHocSinh.Size = new System.Drawing.Size(627, 586);
            this.gcHocSinh.TabIndex = 0;
            this.gcHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinh});
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHS,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.DIACHI});
            this.gvHocSinh.DetailHeight = 525;
            this.gvHocSinh.FixedLineWidth = 3;
            this.gvHocSinh.GridControl = this.gcHocSinh;
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.OptionsSelection.MultiSelect = true;
            this.gvHocSinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvHocSinh.OptionsView.ShowGroupPanel = false;
            this.gvHocSinh.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvHocSinh_CustomDrawCell);
            // 
            // MAHS
            // 
            this.MAHS.Caption = "ID";
            this.MAHS.FieldName = "MAHS";
            this.MAHS.MinWidth = 30;
            this.MAHS.Name = "MAHS";
            this.MAHS.Visible = true;
            this.MAHS.VisibleIndex = 1;
            this.MAHS.Width = 112;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 30;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 2;
            this.HOTEN.Width = 112;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Caption = "GIỚI TINH";
            this.GIOITINH.FieldName = "GIOITINH";
            this.GIOITINH.MinWidth = 30;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 3;
            this.GIOITINH.Width = 112;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Caption = "NGÀY SINH";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.MinWidth = 30;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 4;
            this.NGAYSINH.Width = 112;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 30;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            this.DIACHI.Width = 112;
            // 
            // gcHocSinhLop
            // 
            this.gcHocSinhLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinhLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocSinhLop.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinhLop.MainView = this.gvHocSinhLop;
            this.gcHocSinhLop.Margin = new System.Windows.Forms.Padding(4);
            this.gcHocSinhLop.MenuManager = this.barManager1;
            this.gcHocSinhLop.Name = "gcHocSinhLop";
            this.gcHocSinhLop.Size = new System.Drawing.Size(704, 586);
            this.gcHocSinhLop.TabIndex = 0;
            this.gcHocSinhLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinhLop});
            // 
            // gvHocSinhLop
            // 
            this.gvHocSinhLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHSLOP,
            this.HOTENLOP,
            this.GIOITINHLOP,
            this.TENLOP,
            this.DIACHILOP});
            this.gvHocSinhLop.DetailHeight = 525;
            this.gvHocSinhLop.FixedLineWidth = 3;
            this.gvHocSinhLop.GridControl = this.gcHocSinhLop;
            this.gvHocSinhLop.Name = "gvHocSinhLop";
            this.gvHocSinhLop.OptionsView.ShowGroupPanel = false;
            this.gvHocSinhLop.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvHocSinhLop_CustomDrawCell);
            // 
            // MAHSLOP
            // 
            this.MAHSLOP.Caption = "ID";
            this.MAHSLOP.FieldName = "MAHS";
            this.MAHSLOP.MinWidth = 30;
            this.MAHSLOP.Name = "MAHSLOP";
            this.MAHSLOP.Visible = true;
            this.MAHSLOP.VisibleIndex = 0;
            this.MAHSLOP.Width = 112;
            // 
            // HOTENLOP
            // 
            this.HOTENLOP.Caption = "HỌ TÊN";
            this.HOTENLOP.FieldName = "HOTEN";
            this.HOTENLOP.MinWidth = 30;
            this.HOTENLOP.Name = "HOTENLOP";
            this.HOTENLOP.Visible = true;
            this.HOTENLOP.VisibleIndex = 1;
            this.HOTENLOP.Width = 112;
            // 
            // GIOITINHLOP
            // 
            this.GIOITINHLOP.Caption = "GIỚI TÍNH";
            this.GIOITINHLOP.FieldName = "GIOITINH";
            this.GIOITINHLOP.MinWidth = 30;
            this.GIOITINHLOP.Name = "GIOITINHLOP";
            this.GIOITINHLOP.Visible = true;
            this.GIOITINHLOP.VisibleIndex = 2;
            this.GIOITINHLOP.Width = 112;
            // 
            // TENLOP
            // 
            this.TENLOP.Caption = "LỚP";
            this.TENLOP.FieldName = "TENLOP";
            this.TENLOP.MinWidth = 30;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Visible = true;
            this.TENLOP.VisibleIndex = 3;
            this.TENLOP.Width = 112;
            // 
            // DIACHILOP
            // 
            this.DIACHILOP.Caption = "ĐỊA CHỈ";
            this.DIACHILOP.FieldName = "DIACHI";
            this.DIACHILOP.MinWidth = 30;
            this.DIACHILOP.Name = "DIACHILOP";
            this.DIACHILOP.Visible = true;
            this.DIACHILOP.VisibleIndex = 4;
            this.DIACHILOP.Width = 112;
            // 
            // fPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 691);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fPhanLop";
            this.Text = "Phân lớp";
            this.Load += new System.EventHandler(this.fPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnSave;
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
        private System.Windows.Forms.ComboBox cbLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbKhoiLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private DevExpress.XtraEditors.LabelControl lbHo;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn MAHS;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.GridControl gcHocSinhLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn MAHSLOP;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINHLOP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHILOP;
    }
}