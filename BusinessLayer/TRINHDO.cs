using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRINHDO
    {
        HSEntities db;
        public TRINHDO()
        {
            db = new HSEntities();
        }

        public tb_TrinhDo getItem(int matd)
        {
            return db.tb_TrinhDo.FirstOrDefault(x => x.MATD == matd);
        }

        public List<tb_TrinhDo> getList()
        {
            return db.tb_TrinhDo.ToList();
        }

        public tb_TrinhDo Add(tb_TrinhDo td)
        {
            try
            {
                db.tb_TrinhDo.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_TrinhDo Update(tb_TrinhDo td)
        {
            try
            {
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MATD == td.MATD);
                if (_td != null)
                {
                    _td.TENTD = td.TENTD;
                    _td.UPDATEDBY = td.UPDATEDBY;
                    _td.UPDATEDDATE = td.UPDATEDDATE;
                }
                db.SaveChanges();
                return td;
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
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MATD == matd);
                _td.DELETEDBY = userID;
                _td.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
