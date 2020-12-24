using BookVendor.Repository;
using System;
using BookVendor.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Email"] != null)
            {
                LoginEmail.Text = Request.Cookies["Email"].Value.ToString();
                LoginPassword.Attributes["value"] = Request.Cookies["Password"].Value.ToString();
            }
        }

        protected void LoginButton1_Click(object sender, EventArgs e)
        {
            string username = LoginEmail.Text;
            string password = LoginPassword.Text;   
            if (UserRepository.LoginUser(username, password) != null)
            {
                User user = UserController.LoginUser(username, password);

                if (user.Banned == 0)
                {
                    Session.Timeout = 30;
                    Session["user"] = UserController.LoginUser(username, password);
                    if (RememberMe.Checked)
                    {
                        Response.Cookies["Email"].Value = LoginEmail.Text;
                        Response.Cookies["Password"].Value = LoginPassword.Text;
                    }
                    else if(Request.Cookies["Email"]!=null && !RememberMe.Checked)
                    {
                        Response.Cookies["Email"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                    }
                    Response.Redirect("../HomePage.aspx");
                }
                else
                {
                    error.Text = "User dibanned";
                }   
            }
            else
            {
                error.Text = "Email atau Password salah";
            }
        }
    }
}