using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class THONGKE_VIPHAM
    {
        HSEntities db;
        public THONGKE_VIPHAM()
        {
            db = new HSEntities();
        }

        public List<THONGKE_VIPAHM_NAMHOC_Result> ThongKeViPhamNamHoc(int manh)
        {
            return db.THONGKE_VIPAHM_NAMHOC(manh).ToList();
        }
    }
}
