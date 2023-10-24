using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MONHOC
    {
        HSEntities db;
        public MONHOC()
        {
            db = new HSEntities();
        }

        public tb_MonHoc getItem(int mamh)
        {
            return db.tb_MonHoc.FirstOrDefault(x => x.MAMH == mamh);
        }

        public List<tb_MonHoc> getList()
        {
            return db.tb_MonHoc.ToList();
        }

        public tb_MonHoc Add(tb_MonHoc mh)
        {
            try
            {
                db.tb_MonHoc.Add(mh);
                db.SaveChanges();
                return mh;
            }catch(Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_MonHoc Update(tb_MonHoc mh)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MAMH == mh.MAMH);
                if(_mh != null)
                {
                    _mh.TENMH = mh.TENMH;
                    _mh.HESO = mh.HESO;
                    _mh.SOTIET = mh.SOTIET;
                    _mh.UPDATEDBY = mh.UPDATEDBY;
                    _mh.UPDATEDDATE = mh.UPDATEDDATE;
                }
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int mamh, int userID)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MAMH == mamh);
                _mh.DELETEDBY = userID;
                _mh.DELETEDDATE = DateTime.Now;
                db.tb_MonHoc.Remove(_mh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
