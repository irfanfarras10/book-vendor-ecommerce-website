using BookVendor.Handler;
using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Controller
{
    public class UserController
    {
        public static void RegisterUser(int roleid, string Username,
            string Name, string Password, string Gender, string Phonenumber, string Adress, int banned)
        {
            UserHandler.RegisterUser(roleid, Username,
            Name, Password, Gender, Phonenumber, Adress, banned);
        }

        public static void UpdateUser(int userid, string name, string gender, string phone, string adress)
        {
            UserHandler.UpdateUser(userid, name, gender, phone, adress);
        }

        public static User ChangePassword(int userid, string password, string oldpass)
        {
            return UserHandler.ChangePassword(userid, password, oldpass);
        }

        public static User check(string username)
        {
            return UserHandler.check(username);
        }

        public static User LoginUser(string Username, string Password)
        {
            return UserHandler.LoginUser(Username, Password);
        }

        public static User GetProfile(int userid)
        {
            return UserHandler.GetProfile(userid);
        }

        public static List<User> GetUser()
        {
            return UserHandler.GetUser();
        }

        public static void Promote(int userid)
        {
            UserHandler.Promote(userid);
        }

        public static void Ban(int userid)
        {
            UserHandler.Ban(userid);
        }

        public static void Delete(int userid)
        {
            UserHandler.Delete(userid);
        }
    }
}