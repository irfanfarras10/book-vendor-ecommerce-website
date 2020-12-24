using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Handler
{
    public class UserHandler
    {
        public static void RegisterUser(int roleid, string Username,
            string Name, string Password, string Gender, string Phonenumber, string Adress, int banned)
        {
            UserRepository.RegisterUser(roleid, Username,
            Name, Password, Gender, Phonenumber, Adress, banned);
        }

        public static void UpdateUser(int userid, string name, string gender, string phone, string adress)
        {
            UserRepository.UpdateUser(userid, name, gender, phone, adress);
        }

        public static User ChangePassword(int userid, string password, string oldpass)
        {
           return UserRepository.ChangePassword(userid, password, oldpass);
        }

        public static User check(string username)
        {
            return UserRepository.check(username);
        }

        public static User LoginUser(string Username, string Password)
        {
            return UserRepository.LoginUser(Username, Password);
        }

        public static User GetProfile(int userid)
        {
            return UserRepository.GetProfile(userid);
        }

        public static List<User> GetUser()
        {
            return UserRepository.GetUser();
        }

        public static void Promote(int userid)
        {
           UserRepository.Promote(userid);
        }

        public static void Ban(int userid)
        {
            UserRepository.Ban(userid);
        }

        public static void Delete(int userid)
        {
            UserRepository.Delete(userid);
        }


    }
}