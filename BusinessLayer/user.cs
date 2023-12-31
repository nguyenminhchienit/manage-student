﻿using DataAccessLayer;
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

        public bool getUser(string username)
        {
            var u = db.tb_User.FirstOrDefault(x => x.USERNAME == username);
            if (u != null)
            {
                return true;
            }
            return false;
        }

        public tb_User getItemByID(int id)
        {
            return db.tb_User.FirstOrDefault(x => x.UID == id);

        }

        public List<tb_User> getList()
        {
            return db.tb_User.ToList();

        }

        public tb_User getItemByEmail(string email)
        {
            return db.tb_User.FirstOrDefault(x => x.EMAIL == email);

        }

        public tb_User Add(tb_User user)
        {
            try
            {
                db.tb_User.Add(user);
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
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

        public tb_User Update(tb_User u)
        {
            try
            {
                var _u = db.tb_User.FirstOrDefault(x => x.EMAIL == u.EMAIL);
                if (_u != null)
                {
                    _u.PASSWORD = u.PASSWORD;
                }
                db.SaveChanges();
                return u;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }

        public bool Delete(int id, int uid)
        {
            try
            {
                if(id == uid)
                {
                    return false;
                }
                var _u = db.tb_User.FirstOrDefault(x => x.UID == id);
                db.tb_User.Remove(_u);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error + ", ex);
            }
        }
    }
}
