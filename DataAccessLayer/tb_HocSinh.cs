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
    
    public partial class tb_HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_HocSinh()
        {
            this.tb_ChiTietVP = new HashSet<tb_ChiTietVP>();
        }
    
        public int MAHS { get; set; }
        public string EMAIL { get; set; }
        public string HOTEN { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<int> MADT { get; set; }
        public Nullable<int> MATG { get; set; }
        public string GHICHU { get; set; }
        public string DIACHI { get; set; }
        public string DT { get; set; }
        public Nullable<bool> ISPHANLOP { get; set; }
        public Nullable<double> DIEMTOAN { get; set; }
        public Nullable<double> DIEMLY { get; set; }
        public Nullable<double> DTB { get; set; }
        public string HOCLUC { get; set; }
        public Nullable<double> DIEMHOA { get; set; }
        public string TEN { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
        public Nullable<int> GIOITINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ChiTietVP> tb_ChiTietVP { get; set; }
    }
}
