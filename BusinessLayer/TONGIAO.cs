using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TONGIAO
    {
        HSEntities db;
        public TONGIAO()
        {
            db = new HSEntities();
        }

        public tb_TonGiao getItem(int matg)
        {
            return db.tb_TonGiao.FirstOrDefault(x => x.MATG == matg);
        }

        public List<tb_TonGiao> getList()
        {
            return db.tb_TonGiao.ToList();
        }

        public tb_TonGiao Add(tb_TonGiao mh)
        {
            try
            {
                db.tb_TonGiao.Add(mh);
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_TonGiao Update(tb_TonGiao mh)
        {
            try
            {
                var _mh = db.tb_TonGiao.FirstOrDefault(x => x.MATG == mh.MATG);
                if (_mh != null)
                {
                    _mh.TENTG = mh.TENTG;
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

        public void Delete(int matg, int userID)
        {
            try
            {
                var _mh = db.tb_TonGiao.FirstOrDefault(x => x.MATG == matg);
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
