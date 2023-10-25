using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VIPHAM
    {
        HSEntities db;
        public VIPHAM()
        {
            db = new HSEntities();
        }

        public tb_ViPham getItem(int mavp)
        {
            return db.tb_ViPham.FirstOrDefault(x => x.MAVP == mavp);
        }

        public List<tb_ViPham> getList()
        {
            return db.tb_ViPham.ToList();
        }

        public List<tb_ViPham> getList(int manh, int malop, int mahk)
        {
            return db.tb_ViPham.Where(x => x.MANH ==manh && x.MALOP == malop && x.MAHK == mahk).ToList();
        }

        public tb_ViPham Add(tb_ViPham mh)
        {
            try
            {
                db.tb_ViPham.Add(mh);
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_ViPham Update(tb_ViPham vp)
        {
            try
            {
                var _vp = db.tb_ViPham.FirstOrDefault(x => x.MAVP == vp.MAVP);
                if (_vp != null)
                {
                    _vp.MAHK = vp.MAHK;
                    _vp.MALOP = vp.MALOP;
                    _vp.MANH = vp.MANH;
                    _vp.GHICHU = vp.GHICHU;
                    _vp.NGAYVP = vp.NGAYVP;
                    _vp.TONGSOLOI = vp.TONGSOLOI;
                    _vp.TONGDIEMTRU = vp.TONGDIEMTRU;
                    _vp.UPDATEDBY = vp.UPDATEDBY;
                    _vp.UPDATEDDATE = vp.UPDATEDDATE;
                }
                db.SaveChanges();
                return vp;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int mavp)
        {
            try
            {
                var _mh = db.tb_ViPham.FirstOrDefault(x => x.MAVP == mavp);
                db.tb_ViPham.Remove(_mh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
