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
    
    public partial class tb_ChiTietVP
    {
        public int MAVPCT { get; set; }
        public Nullable<int> MAVP { get; set; }
        public Nullable<int> MALOI { get; set; }
        public Nullable<int> MAHS { get; set; }
        public Nullable<int> DIEM { get; set; }
        public Nullable<System.DateTime> NGAYVP { get; set; }
        public string GHICHU { get; set; }
    
        public virtual tb_ViPham tb_ViPham { get; set; }
        public virtual tb_DanhMucLoi tb_DanhMucLoi { get; set; }
        public virtual tb_HocSinh tb_HocSinh { get; set; }
    }
}
