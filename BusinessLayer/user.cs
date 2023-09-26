using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class user
    {
        HSEntities db;

        public user()
        {
            db = new HSEntities();
        }

        public tb_User getItem(string username)
        {
            return db.tb_User.FirstOrDefault(x => x.USERNAME == username);
            
        }

        public int Login(string username, string password)
        {
            var us = db.tb_User.FirstOrDefault(x => x.USERNAME == username && x.PASSWORD == password);
            if(us != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
