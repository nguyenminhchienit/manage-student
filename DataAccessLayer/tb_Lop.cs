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
    
    public partial class tb_Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Lop()
        {
            this.tb_GiaoVien_Lop = new HashSet<tb_GiaoVien_Lop>();
            this.tb_ViPham = new HashSet<tb_ViPham>();
        }
    
        public int MALOP { get; set; }
        public string TENLOP { get; set; }
        public Nullable<int> MAKHOI { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_GiaoVien_Lop> tb_GiaoVien_Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ViPham> tb_ViPham { get; set; }
    }
}
