using DataAccessLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace ManageStudent.Report
{
    public partial class Diem_report : DevExpress.XtraReports.UI.XtraReport
    {
        public Diem_report()
        {
            InitializeComponent();
        }
        public void InitData(List<tb_HocSinh> data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
