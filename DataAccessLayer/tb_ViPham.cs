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
    
    public partial class tb_ViPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ViPham()
        {
            this.tb_ChiTietVP = new HashSet<tb_ChiTietVP>();
        }
    
        public int MAVP { get; set; }
        public Nullable<System.DateTime> NGAYVP { get; set; }
        public Nullable<int> TONGSOLOI { get; set; }
        public Nullable<int> TONGDIEMTRU { get; set; }
        public Nullable<int> MALOP { get; set; }
        public Nullable<int> MANH { get; set; }
        public Nullable<int> MAHK { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietVP> tb_ChiTietVP { get; set; }
        public virtual tb_HocKy tb_HocKy { get; set; }
        public virtual tb_Lop tb_Lop { get; set; }
        public virtual tb_NamHoc tb_NamHoc { get; set; }
    }
}
