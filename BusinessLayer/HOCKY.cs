using BusinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HOCKY
    {
        HSEntities db;
        public HOCKY()
        {
            db = new HSEntities();
        }

        public tb_HocKy getItem(int mahk)
        {
            return db.tb_HocKy.FirstOrDefault(x => x.MAHK == mahk);
        }

        public List<tb_HocKy> getList(int manh)
        {
            return db.tb_HocKy.Where(x => x.MANH == manh).ToList();
        }

        public List<HocKyDTO> getListFull()
        {
            var list = db.tb_HocKy.ToList();
            List<HocKyDTO> lsHK = new List<HocKyDTO>();
            HocKyDTO hkDTO;
            foreach (var item in list)
            {
                hkDTO = new HocKyDTO();
                hkDTO.MAHK = item.MAHK;
                hkDTO.TENHK = item.TENHK;
                hkDTO.HESO = item.HESO;

                hkDTO.MANH = item.MANH;
                var nh = db.tb_NamHoc.FirstOrDefault(n => n.MANH == item.MANH);
                hkDTO.TENNH = nh.TENNH;

                hkDTO.CREATEDBY = item.CREATEDBY;
                hkDTO.CREATEDDATE = item.CREATEDDATE;
                hkDTO.UPDATEDBY = item.UPDATEDBY;
                hkDTO.UPDATEDDATE = item.UPDATEDDATE;
                hkDTO.DELETEDBY = item.DELETEDBY;
                hkDTO.DELETEDDATE = item.DELETEDDATE;

                lsHK.Add(hkDTO);
            }
            return lsHK;
        }

        public tb_HocKy Add(tb_HocKy hk)
        {
            try
            {
                db.tb_HocKy.Add(hk);
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_HocKy Update(tb_HocKy hk)
        {
            try
            {
                var _hk = db.tb_HocKy.FirstOrDefault(x => x.MAHK == hk.MAHK);
                if (_hk != null)
                {
                 
                    _hk.TENHK = hk.TENHK;
                    _hk.HESO = hk.HESO;
                    
                    _hk.MANH = hk.MANH;
                    _hk.UPDATEDBY = hk.UPDATEDBY;
                    _hk.UPDATEDDATE = hk.UPDATEDDATE;
                }
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int mahk, int userID)
        {
            try
            {
                var _hk = db.tb_HocKy.FirstOrDefault(x => x.MAHK == mahk);
                _hk.DELETEDBY = userID;
                _hk.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
