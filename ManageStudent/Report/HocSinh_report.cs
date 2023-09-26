using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace ManageStudent.Report
{
    public partial class HocSinh_report : DevExpress.XtraReports.UI.XtraReport
    {
        public HocSinh_report()
        {
            InitializeComponent();
        }

        public void InitData(List<HocSinhDTO> data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
