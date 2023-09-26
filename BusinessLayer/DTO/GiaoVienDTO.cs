using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public partial class GiaoVienDTO
    {
        public int MAGV { get; set; }
        public string TEN { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public byte[] HINHANH { get; set; }
        public string DT { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public Nullable<int> MATD { get; set; }
        public Nullable<int> MACV { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }

        public string TENTD { get; set; }

        public string TENCV { get; set; }

    }
}
