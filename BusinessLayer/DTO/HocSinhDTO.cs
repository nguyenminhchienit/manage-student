using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public partial class HocSinhDTO
    {
        public int MAHS { get; set; }
        public string EMAIL { get; set; }
        public string HOTEN { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<int> MADT { get; set; }

        public string TENDT { get; set; }

        public Nullable<int> MALOP { get; set; }

        public string TENLOP { get; set; }
        public Nullable<int> MATG { get; set; }

        public string TENTG { get; set; }
        public string GHICHU { get; set; }
        public string DIACHI { get; set; }
        public string DT { get; set; }
        public string TEN { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
        public Nullable<int> GIOITINH { get; set; }
    }
}
