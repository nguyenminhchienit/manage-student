using BusinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HOCSINH
    {
        HSEntities db;
        public HOCSINH()
        {
            db = new HSEntities();
        }

        public tb_HocSinh getItem(int mahs)
        {
            return db.tb_HocSinh.FirstOrDefault(x => x.MAHS == mahs);
        }

        public List<HocSinhDTO> getList()
        {
            var list = db.tb_HocSinh.ToList();
            List<HocSinhDTO> lsHS = new List<HocSinhDTO>();
            HocSinhDTO hsDTO;
            foreach (var item in list)
            {
                hsDTO = new HocSinhDTO();
                hsDTO.MAHS = item.MAHS;
                hsDTO.TEN = item.TEN;
                hsDTO.HOTEN = item.HOTEN;
                hsDTO.GIOITINH = item.GIOITINH;
                hsDTO.NGAYSINH = item.NGAYSINH;
                hsDTO.DIACHI = item.DIACHI;
                hsDTO.DT = item.DT;
                hsDTO.EMAIL = item.EMAIL;
                hsDTO.HINHANH = item.HINHANH;
                hsDTO.GHICHU = item.GHICHU;

                hsDTO.MADT = item.MADT;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MADT == item.MADT);
                hsDTO.TENDT = td.TENDT;

                hsDTO.MATG = item.MATG;
                var cv = db.tb_TonGiao.FirstOrDefault(c => c.MATG == item.MATG);
                hsDTO.TENTG = cv.TENTG;
                
                hsDTO.CREATEDBY = item.CREATEDBY;
                hsDTO.CREATEDDATE = item.CREATEDDATE;
                hsDTO.UPDATEDBY = item.UPDATEDBY;
                hsDTO.UPDATEDDATE = item.UPDATEDDATE;
                hsDTO.DELETEDBY = item.DELETEDBY;
                hsDTO.DELETEDDATE = item.DELETEDDATE;

                lsHS.Add(hsDTO);
            }
            return lsHS;
        }

        public List<HocSinhDTO> getListISPHANLOP()
        {
            var list = db.tb_HocSinh.Where(x => x.ISPHANLOP != true).ToList();
            List<HocSinhDTO> lsHS = new List<HocSinhDTO>();
            HocSinhDTO hsDTO;
            foreach (var item in list)
            {
                hsDTO = new HocSinhDTO();
                hsDTO.MAHS = item.MAHS;
                hsDTO.TEN = item.TEN;
                hsDTO.HOTEN = item.HOTEN;
                hsDTO.GIOITINH = item.GIOITINH;
                hsDTO.NGAYSINH = item.NGAYSINH;
                hsDTO.DIACHI = item.DIACHI;
                hsDTO.DT = item.DT;
                hsDTO.EMAIL = item.EMAIL;
                hsDTO.HINHANH = item.HINHANH;
                hsDTO.GHICHU = item.GHICHU;

                hsDTO.MADT = item.MADT;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MADT == item.MADT);
                hsDTO.TENDT = td.TENDT;

                hsDTO.MATG = item.MATG;
                var cv = db.tb_TonGiao.FirstOrDefault(c => c.MATG == item.MATG);
                hsDTO.TENTG = cv.TENTG;

                hsDTO.CREATEDBY = item.CREATEDBY;
                hsDTO.CREATEDDATE = item.CREATEDDATE;
                hsDTO.UPDATEDBY = item.UPDATEDBY;
                hsDTO.UPDATEDDATE = item.UPDATEDDATE;
                hsDTO.DELETEDBY = item.DELETEDBY;
                hsDTO.DELETEDDATE = item.DELETEDDATE;

                lsHS.Add(hsDTO);
            }
            return lsHS;
        }

        public tb_HocSinh Add(tb_HocSinh hs)
        {
            try
            {
                db.tb_HocSinh.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void UpdateIsPhanLop(int mahs)
        {
            try
            {
                var _hs = db.tb_HocSinh.FirstOrDefault(x => x.MAHS == mahs);
                if (_hs != null)
                {
                    _hs.ISPHANLOP = true;
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_HocSinh Update(tb_HocSinh hs)
        {
            try
            {
                var _hs = db.tb_HocSinh.FirstOrDefault(x => x.MAHS == hs.MAHS);
                if (_hs != null)
                {
                    _hs.TEN = hs.TEN;
                    _hs.HOTEN = hs.HOTEN;
                    _hs.GIOITINH = hs.GIOITINH;
                    _hs.NGAYSINH = hs.NGAYSINH;
                    _hs.HINHANH = hs.HINHANH;
                    _hs.DT = hs.DT;
                    _hs.EMAIL = hs.EMAIL;
                    _hs.DIACHI = hs.DIACHI;
                    _hs.MATG = hs.MATG;
                    _hs.MADT = hs.MADT;
                    _hs.GHICHU = hs.GHICHU;
                    _hs.UPDATEDBY = hs.UPDATEDBY;
                    _hs.UPDATEDDATE = hs.UPDATEDDATE;
                }
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int mahs, int userID)
        {
            try
            {
                var _hs = db.tb_HocSinh.FirstOrDefault(x => x.MAHS == mahs);
                _hs.DELETEDBY = userID;
                _hs.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
