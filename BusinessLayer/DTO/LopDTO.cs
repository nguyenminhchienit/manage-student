using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public partial class LopDTO
    {
        public int MALOP { get; set; }
        public string TENLOP { get; set; }
        public Nullable<int> MAKHOI { get; set; }

        public string GHICHU { get; set; }
        public string TENKHOI { get; set; }

    }
}
