using BusinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GIAOVIEN
    {
        HSEntities db;
        public GIAOVIEN()
        {
            db = new HSEntities();
        }

        public tb_GiaoVien getItem(int magv)
        {
            return db.tb_GiaoVien.FirstOrDefault(x => x.MAGV == magv);
        }

        public List<GiaoVienDTO> getList()
        {
            var list = db.tb_GiaoVien.ToList();
            List<GiaoVienDTO> lsGV = new List<GiaoVienDTO>();
            GiaoVienDTO gvDTO;
            foreach(var item in list)
            {
                gvDTO = new GiaoVienDTO();
                gvDTO.MAGV = item.MAGV;
                gvDTO.TEN = item.TEN;
                gvDTO.HOTEN = item.HOTEN;
                gvDTO.GIOITINH = item.GIOITINH;
                gvDTO.NGAYSINH = item.NGAYSINH;
                gvDTO.DIACHI = item.DIACHI;
                gvDTO.DT = item.DT;
                gvDTO.EMAIL = item.EMAIL;
                gvDTO.HINHANH = item.HINHANH;

                gvDTO.MATD = item.MATD;
                var td = db.tb_TrinhDo.FirstOrDefault(t => t.MATD == item.MATD);
                gvDTO.TENTD = td.TENTD;

                gvDTO.MACV = item.MACV;
                var cv = db.tb_ChucVu.FirstOrDefault(c => c.MACV == item.MACV);
                gvDTO.TENCV = cv.TENCV;

                gvDTO.CREATEDBY = item.CREATEDBY;
                gvDTO.CREATEDDATE = item.CREATEDDATE;
                gvDTO.UPDATEDBY = item.UPDATEDBY;
                gvDTO.UPDATEDDATE = item.UPDATEDDATE;
                gvDTO.DELETEDBY = item.DELETEDBY;
                gvDTO.DELETEDDATE = item.DELETEDDATE;

                lsGV.Add(gvDTO);
            }
            return lsGV;
        }

        public tb_GiaoVien Add(tb_GiaoVien gv)
        {
            try
            {
                db.tb_GiaoVien.Add(gv);
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_GiaoVien Update(tb_GiaoVien gv)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x => x.MAGV == gv.MAGV);
                if (_gv != null)
                {
                    _gv.TEN = gv.TEN;
                    _gv.HOTEN = gv.HOTEN;
                    _gv.GIOITINH = gv.GIOITINH;
                    _gv.NGAYSINH = gv.NGAYSINH;
                    _gv.HINHANH = gv.HINHANH;
                    _gv.DT = gv.DT;
                    _gv.EMAIL = gv.EMAIL;
                    _gv.DIACHI = gv.DIACHI;
                    _gv.MATD = gv.MATD;
                    _gv.MACV = gv.MACV;
                    _gv.UPDATEDBY = gv.UPDATEDBY;
                    _gv.UPDATEDDATE = gv.UPDATEDDATE;
                }
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int magv, int userID)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x => x.MAGV == magv);
                _gv.DELETEDBY = userID;
                _gv.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
