using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOP
    {
        HSEntities db;
        public LOP()
        {
            db = new HSEntities();
        }

        public tb_Lop getItem(int malop)
        {
            return db.tb_Lop.FirstOrDefault(x => x.MALOP == malop);
        }

        public List<tb_Lop> getList(int makhoi)
        {
            return db.tb_Lop.Where(x => x.MAKHOI == makhoi).ToList();
        }

        public tb_Lop Add(tb_Lop hk)
        {
            try
            {
                db.tb_Lop.Add(hk);
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_Lop Update(tb_Lop hk)
        {
            try
            {
                var _hk = db.tb_Lop.FirstOrDefault(x => x.MALOP == hk.MALOP);
                if (_hk != null)
                {
                    _hk.MAKHOI = hk.MAKHOI;
                    _hk.TENLOP = hk.TENLOP;
                    _hk.GHICHU = hk.GHICHU;
                }
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int malop, int userID)
        {
            try
            {
                var _hk = db.tb_Lop.FirstOrDefault(x => x.MALOP == malop);
                db.tb_Lop.Remove(_hk);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
