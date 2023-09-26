using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public partial class vpctDTO
    {
        public int MAVPCT { get; set; }
        public Nullable<int> MAVP { get; set; }
        public Nullable<int> MALOI { get; set; }

        public string TENLOI { get; set; }
        public Nullable<int> MAHS { get; set; }

        public string TENHS { get; set; }
        public Nullable<int> DIEM { get; set; }
        public Nullable<System.DateTime> NGAYVP { get; set; }
        public string GHICHU { get; set; }
    }
}
