using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHOA
    {
        HSEntities db;
        public KHOA()
        {
            db = new HSEntities();
        }

        public tb_KhoiLop getItem(int makhoi)
        {
            return db.tb_KhoiLop.FirstOrDefault(x => x.MAKHOI == makhoi);
        }

        public List<tb_KhoiLop> getList()
        {
            return db.tb_KhoiLop.ToList();
        }

        public tb_KhoiLop Add(tb_KhoiLop hk)
        {
            try
            {
                db.tb_KhoiLop.Add(hk);
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_KhoiLop Update(tb_KhoiLop hk)
        {
            try
            {
                var _hk = db.tb_KhoiLop.FirstOrDefault(x => x.MAKHOI == hk.MAKHOI);
                if (_hk != null)
                {
                    _hk.TENKHOI = hk.TENKHOI;
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
                var _hk = db.tb_KhoiLop.FirstOrDefault(x => x.MAKHOI == mahk);
                db.tb_KhoiLop.Remove(_hk);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
