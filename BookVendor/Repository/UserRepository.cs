using BookVendor.Factory;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Repository
{
    public class UserRepository
    {
        public static void RegisterUser(int roleid,string Username,
            string Name, string Password, string Gender, string Phonenumber, string Adress, int banned)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = UserFactory.CreateUser(roleid,Username, Name, Password, Gender,
                Phonenumber, Adress, banned);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void UpdateUser(int userid,string name,string gender,string phone,string adress)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            user.Name = name;
            user.Gender = gender;
            user.PhoneNumber = phone;
            user.Adress = adress;
            db.SaveChanges();
        }

        public static User ChangePassword(int userid,string password,string oldpass)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            User check = db.Users.Where(a => a.Password == oldpass && a.UserID ==userid).FirstOrDefault();
            if (check != null)
            {
                user.Password = password;
                db.SaveChanges();
            }
            return check;
        }

        public static User check(string username)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User check = db.Users.Where(a => a.Username == username).FirstOrDefault();
            return check;
        }

        public static User LoginUser(string Username, string Password)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User check = db.Users.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
            return check;
        }

        public static User GetProfile(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            return user;
        }

        public static List<User> GetUser()
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<User> list = new List<User>();
            list = db.Users.ToList();
            return list; 
        }

        public static void Promote(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            user.RoleID = 1;
            db.SaveChanges();
        }

        public static void Ban(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            if (user.Banned == 1)
            {
                user.Banned = 0;
            }
            else
            {
                user.Banned = 1;
            }
            db.SaveChanges();
        }

        public static void Delete(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            User user = db.Users.Find(userid);
            db.Users.Remove(user);
            db.SaveChanges();
        }

    }
}