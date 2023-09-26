using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DANTOC
    {
        HSEntities db;
        public DANTOC()
        {
            db = new HSEntities();
        }

        public tb_DanToc getItem(int madt)
        {
            return db.tb_DanToc.FirstOrDefault(x => x.MADT == madt);
        }

        public List<tb_DanToc> getList()
        {
            return db.tb_DanToc.ToList();
        }

        public tb_DanToc Add(tb_DanToc mh)
        {
            try
            {
                db.tb_DanToc.Add(mh);
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_DanToc Update(tb_DanToc mh)
        {
            try
            {
                var _mh = db.tb_DanToc.FirstOrDefault(x => x.MADT == mh.MADT);
                if (_mh != null)
                {
                    _mh.TENDT = mh.TENDT;
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

        public void Delete(int madt, int userID)
        {
            try
            {
                var _mh = db.tb_DanToc.FirstOrDefault(x => x.MADT == madt);
                _mh.DELETEDBY = userID;
                _mh.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
