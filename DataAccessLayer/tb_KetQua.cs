//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_KetQua
    {
        public int MAKQ { get; set; }
        public Nullable<int> MAMH { get; set; }
        public Nullable<int> MAHS { get; set; }
        public Nullable<double> DIEMKIEMTRA { get; set; }
        public Nullable<double> DIEMTHIL1 { get; set; }
        public Nullable<double> DIEMTHIL2 { get; set; }
        public Nullable<double> DTB { get; set; }
        public string XEPLOAI { get; set; }
        public Nullable<int> MANH { get; set; }
        public Nullable<int> MAHK { get; set; }
        public Nullable<int> MALOP { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
    
        public virtual tb_HocKy tb_HocKy { get; set; }
        public virtual tb_HocSinh tb_HocSinh { get; set; }
        public virtual tb_NamHoc tb_NamHoc { get; set; }
        public virtual tb_Lop tb_Lop { get; set; }
        public virtual tb_MonHoc tb_MonHoc { get; set; }
    }
}