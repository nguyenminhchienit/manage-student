using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DANHMUCLOI
    {
        HSEntities db;
        public DANHMUCLOI()
        {
            db = new HSEntities();
        }

        public tb_DanhMucLoi getItem(int maloi)
        {
            return db.tb_DanhMucLoi.FirstOrDefault(x => x.MALOI == maloi);
        }

        public List<tb_DanhMucLoi> getList()
        {
            return db.tb_DanhMucLoi.ToList();
        }

        public tb_DanhMucLoi Add(tb_DanhMucLoi dml)
        {
            try
            {
                db.tb_DanhMucLoi.Add(dml);
                db.SaveChanges();
                return dml;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public tb_DanhMucLoi Update(tb_DanhMucLoi dml)
        {
            try
            {
                var _dml = db.tb_DanhMucLoi.FirstOrDefault(x => x.MALOI == dml.MALOI);
                if (_dml != null)
                {
                    _dml.TENLOI = dml.TENLOI;
                    _dml.GHICHU = dml.GHICHU;
                    _dml.NGHIEMTRONG = dml.NGHIEMTRONG;
                    _dml.DIEM = dml.DIEM;
                    _dml.UPDATEDBY = dml.UPDATEDBY;
                    _dml.UPDATEDDATE = dml.UPDATEDDATE;
                }
                db.SaveChanges();
                return dml;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public void Delete(int maloi, int userID)
        {
            try
            {
                var _dml = db.tb_DanhMucLoi.FirstOrDefault(x => x.MALOI == maloi);
                _dml.DELETEDBY = userID;
                _dml.DELETEDDATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
