using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUCVU
    {
        HSEntities db;
        public CHUCVU()
        {
            db = new HSEntities();
        }

        public tb_ChucVu getItem(int macv)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.MACV == macv);
        }

        public List<tb_ChucVu> getList()
        {
            return db.tb_ChucVu.ToList();
        }

        public tb_ChucVu Add(tb_ChucVu cv)
        {
            try
            {
                db.tb_ChucVu.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_ChucVu Update(tb_ChucVu cv)
        {
            try
            {
                var _cv = db.tb_ChucVu.FirstOrDefault(x => x.MACV == cv.MACV);
                if (_cv != null)
                {
                    _cv.TENCV = cv.TENCV;
                    _cv.UPDATEDBY = cv.UPDATEDBY;
                    _cv.UPDATEDDATE = cv.UPDATEDDATE;
                }
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int matd, int userID)
        {
            try
            {
                var _cv = db.tb_ChucVu.FirstOrDefault(x => x.MACV == matd);
                _cv.DELETEDBY = userID;
                _cv.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
