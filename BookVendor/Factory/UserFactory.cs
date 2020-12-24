using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Factory
{
    public class UserFactory
    {
        public static User CreateUser(int roleid, string Username,
            string Name,string Password,string Gender, string Phonenumber,string Adress, int banned)
        {
            User user = new User();
            user.RoleID = roleid;
            user.Username = Username;
            user.Password = Password;
            user.Name = Name;
            user.Gender = Gender;
            user.PhoneNumber = Phonenumber;
            user.Adress = Adress;
            user.Banned = banned;
            return user;
        }
    }
}