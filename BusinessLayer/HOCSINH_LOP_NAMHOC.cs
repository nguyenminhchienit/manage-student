using BusinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HOCSINH_LOP_NAMHOC
    {
        HSEntities db;
        public HOCSINH_LOP_NAMHOC()
        {
            db = new HSEntities();
        }

        public List<HocSinhDTO> getList(int manh, int malop)
        {
            var list = db.tb_HS_Lop_NamHoc.Where(x => x.MANH == manh && x.MALOP == malop).ToList();
            List<HocSinhDTO> lsHS = new List<HocSinhDTO>();
            HocSinhDTO hsDTO;
            foreach (var item in list)
            {
                hsDTO = new HocSinhDTO();
                hsDTO.MAHS = item.MAHS;
                var hs = db.tb_HocSinh.FirstOrDefault(x => x.MAHS == item.MAHS);
                hsDTO.TEN = hs.TEN;
                hsDTO.HOTEN = hs.HOTEN;
                hsDTO.NGAYSINH = hs.NGAYSINH;
                hsDTO.GIOITINH = hs.GIOITINH;
                hsDTO.DIACHI = hs.DIACHI;
                hsDTO.DT = hs.DT;
                hsDTO.EMAIL = hs.EMAIL;
                hsDTO.HINHANH = hs.HINHANH;
                hsDTO.GHICHU = hs.GHICHU;
                hsDTO.MALOP = item.MALOP;
                hsDTO.MADT = hs.MADT;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MADT == hs.MADT);
                hsDTO.TENDT = td.TENDT;

                hsDTO.MATG = hs.MATG;
                var cv = db.tb_TonGiao.FirstOrDefault(c => c.MATG == hs.MATG);
                hsDTO.TENTG = cv.TENTG;
                var l = db.tb_Lop.FirstOrDefault(x => x.MALOP == item.MALOP);
                hsDTO.TENLOP = l.TENLOP;

                lsHS.Add(hsDTO);
            }
            return lsHS;
        }

        public tb_HS_Lop_NamHoc Add(tb_HS_Lop_NamHoc hs)
        {
            try
            {
                db.tb_HS_Lop_NamHoc.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
