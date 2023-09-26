using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public partial class HocKyDTO
    {
        public int MAHK { get; set; }
        public string TENHK { get; set; }
        public Nullable<int> HESO { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDDATE { get; set; }
        public Nullable<int> UPDATEDBY { get; set; }
        public Nullable<System.DateTime> DELETEDDATE { get; set; }
        public Nullable<int> DELETEDBY { get; set; }
        public Nullable<int> MANH { get; set; }

        public string TENNH { get; set; }
    }
}
