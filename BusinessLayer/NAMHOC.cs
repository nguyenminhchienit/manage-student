using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NAMHOC
    {
        HSEntities db;
        public NAMHOC()
        {
            db = new HSEntities();
        }

        public tb_NamHoc getItem(int manh)
        {
            return db.tb_NamHoc.FirstOrDefault(x => x.MANH == manh);
        }

        public List<tb_NamHoc> getList()
        {
            return db.tb_NamHoc.ToList();
        }

        public tb_NamHoc Add(tb_NamHoc nh)
        {
            try
            {
                db.tb_NamHoc.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_NamHoc Update(tb_NamHoc nh)
        {
            try
            {
                var _nh = db.tb_NamHoc.FirstOrDefault(x => x.MANH == nh.MANH);
                if (_nh != null)
                {
                    _nh.TENNH = nh.TENNH;
                    _nh.UPDATEDBY = nh.UPDATEDBY;
                    _nh.UPDATEDDATE = nh.UPDATEDDATE;
                }
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int manh, int userID)
        {
            try
            {
                var _nh = db.tb_NamHoc.FirstOrDefault(x => x.MANH == manh);
                _nh.DELETEDBY = userID;
                _nh.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
