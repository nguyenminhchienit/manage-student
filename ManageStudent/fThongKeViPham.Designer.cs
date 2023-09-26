
namespace ManageStudent
{
    partial class fThongKeViPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongKeViPham));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnBaoCao);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xem);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 631);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 6;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(260, 29);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(238, 32);
            this.cbNamHoc.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(894, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(153, 52);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = true;
            this.btnBaoCao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaoCao.ImageOptions.SvgImage")));
            this.btnBaoCao.Location = new System.Drawing.Point(711, 21);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(154, 52);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "In báo cáo";
            // 
            // btn_Xem
            // 
            this.btn_Xem.AutoSize = true;
            this.btn_Xem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xem.ImageOptions.SvgImage")));
            this.btn_Xem.Location = new System.Drawing.Point(546, 21);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(100, 52);
            this.btn_Xem.TabIndex = 2;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(140, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm học";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(598, 160);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(8, 8);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.UseWaitCursor = true;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1216, 530);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.UseWaitCursor = true;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach,
            this.gridView1});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANH,
            this.TENNH,
            this.MAKL,
            this.TENKHOI,
            this.TENLOP,
            this.DIEM});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // MANH
            // 
            this.MANH.Caption = "Mã năm học";
            this.MANH.FieldName = "MANH";
            this.MANH.MaxWidth = 80;
            this.MANH.MinWidth = 80;
            this.MANH.Name = "MANH";
            this.MANH.Width = 80;
            // 
            // TENNH
            // 
            this.TENNH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TENNH.AppearanceHeader.Options.UseFont = true;
            this.TENNH.Caption = "NĂM HỌC";
            this.TENNH.FieldName = "TENNH";
            this.TENNH.MaxWidth = 300;
            this.TENNH.MinWidth = 300;
            this.TENNH.Name = "TENNH";
            this.TENNH.Visible = true;
            this.TENNH.VisibleIndex = 0;
            this.TENNH.Width = 300;
            // 
            // MAKL
            // 
            this.MAKL.Caption = "MAKL";
            this.MAKL.FieldName = "MAKL";
            this.MAKL.MinWidth = 30;
            this.MAKL.Name = "MAKL";
            this.MAKL.Width = 112;
            // 
            // TENKHOI
            // 
            this.TENKHOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TENKHOI.AppearanceHeader.Options.UseFont = true;
            this.TENKHOI.Caption = "TÊN KHỐI";
            this.TENKHOI.FieldName = "TENKHOI";
            this.TENKHOI.MaxWidth = 200;
            this.TENKHOI.MinWidth = 200;
            this.TENKHOI.Name = "TENKHOI";
            this.TENKHOI.Visible = true;
            this.TENKHOI.VisibleIndex = 1;
            this.TENKHOI.Width = 200;
            // 
            // TENLOP
            // 
            this.TENLOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TENLOP.AppearanceHeader.Options.UseFont = true;
            this.TENLOP.Caption = "LỚP";
            this.TENLOP.FieldName = "TENLOP";
            this.TENLOP.MaxWidth = 100;
            this.TENLOP.MinWidth = 100;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Visible = true;
            this.TENLOP.VisibleIndex = 2;
            this.TENLOP.Width = 100;
            // 
            // DIEM
            // 
            this.DIEM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DIEM.AppearanceHeader.Options.UseFont = true;
            this.DIEM.Caption = "ĐIỂM";
            this.DIEM.FieldName = "DIEM";
            this.DIEM.MaxWidth = 100;
            this.DIEM.MinWidth = 100;
            this.DIEM.Name = "DIEM";
            this.DIEM.Visible = true;
            this.DIEM.VisibleIndex = 3;
            this.DIEM.Width = 100;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // fThongKeViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 631);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fThongKeViPham";
            this.Text = "Thống kê vi phạm";
            this.Load += new System.EventHandler(this.fThongKeViPham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraEditors.SimpleButton btn_Xem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MANH;
        private DevExpress.XtraGrid.Columns.GridColumn TENNH;
        private DevExpress.XtraGrid.Columns.GridColumn MAKL;
        private DevExpress.XtraGrid.Columns.GridColumn TENKHOI;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}