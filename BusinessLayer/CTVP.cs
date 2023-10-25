using BusinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CTVP
    {
        HSEntities db;
        public CTVP()
        {
            db = new HSEntities();
        }

        public tb_ChiTietVP getItem(int vpct)
        {
            return db.tb_ChiTietVP.FirstOrDefault(x => x.MAVPCT == vpct);
        }

        public List<tb_ChiTietVP> getList(int mavp)
        {
            return db.tb_ChiTietVP.Where(x => x.MAVPCT == mavp).ToList();
        }

        public List<vpctDTO> getListFull()
        {
            var list = db.tb_ChiTietVP.ToList();
            List<vpctDTO> listVP = new List<vpctDTO>();
            vpctDTO dto;
            foreach (var item in list)
            {
                dto = new vpctDTO();
                dto.MAVPCT = item.MAVPCT;
                dto.NGAYVP = item.NGAYVP;
                dto.DIEM = item.DIEM;
                dto.GHICHU = item.GHICHU;
                dto.MAVP = item.MAVP;

                dto.MALOI = item.MALOI;
                var loi = db.tb_DanhMucLoi.FirstOrDefault(t => t.MALOI == item.MALOI);
                dto.TENLOI = loi.TENLOI;

                dto.MAHS = item.MAHS;
                var hs = db.tb_HocSinh.FirstOrDefault(c => c.MAHS == item.MAHS);
                dto.TENHS = hs.HOTEN;

                listVP.Add(dto);
            }
            return listVP;
        }

        public tb_ChiTietVP Add(tb_ChiTietVP gv)
        {
            try
            {
                db.tb_ChiTietVP.Add(gv);
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_ChiTietVP Update(tb_ChiTietVP ctvp)
        {
            try
            {
                var _vp = db.tb_ChiTietVP.FirstOrDefault(x => x.MAVPCT == ctvp.MAVPCT);
                if (_vp != null)
                {
                    _vp.MAVP = ctvp.MAVP;
                    _vp.MALOI = ctvp.MALOI;
                    _vp.MAHS = ctvp.MAHS;
                    _vp.NGAYVP = ctvp.NGAYVP;
                    _vp.GHICHU = ctvp.GHICHU;
                    _vp.DIEM = ctvp.DIEM;               
                }
                db.SaveChanges();
                return ctvp;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int mavp, int userID)
        {
            try
            {
                var _vpct = db.tb_ChiTietVP.FirstOrDefault(x => x.MAVP == mavp);
                db.tb_ChiTietVP.Remove(_vpct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
