using BookVendor.Controller;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookVendor
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                HyperLink1.Visible = false;
                HyperLink2.Visible = false;
                HyperLink3.Visible = false;
                HyperLink14.Visible = false;
                HyperLink4.Visible = false;
                HyperLink7.Visible = false;
                UserLogout.Visible = false;
                HyperLink5.Visible = true;
                HyperLink6.Visible = true;
                HyperLink8.Visible = false;
                HyperLink9.Visible = false;
                HyperLink10.Visible = false;
                HyperLink11.Visible = false;
                HyperLink13.Visible = false;
            }
            else
            {
                int cartcount;
                if (CartController.GetCart(((User)Session["user"]).UserID).Count == 0)
                {
                    cartcount = 0;
                }
                else
                {
                    cartcount = CartController.GetCart(((User)Session["user"]).UserID).Count;
                }
                String role = ((User)Session["user"]).Role.RoleName;
                if (role == "Administrator")
                {
                    HyperLink1.Visible = true;
                    HyperLink1.NavigateUrl = HyperLink9.NavigateUrl;
                    HyperLink2.Visible = true;
                    HyperLink3.Visible = false;
                    HyperLink4.Visible = false;
                    UserLogout.Visible = true;
                    HyperLink7.Visible = true;
                    HyperLink14.Visible = true;
                    HyperLink8.Visible = true;
                    HyperLink9.Visible = false;
                    HyperLink10.Visible = true;
                    HyperLink11.Visible = true;
                    HyperLink13.Visible = true;
                    HyperLink5.Visible = false;
                    HyperLink6.Visible = false;
                    Username.Text = " | Hi, " + ((User)Session["user"]).Username;
                }
                else
                {
                    HyperLink1.Visible = true;
                    HyperLink2.Visible = true;
                    HyperLink3.Visible = true;
                    HyperLink4.Visible = true;
                    UserLogout.Visible = true;
                    HyperLink7.Visible = true;
                    HyperLink14.Visible = false;
                    HyperLink5.Visible = false;
                    HyperLink6.Visible = false;
                    HyperLink8.Visible = false;
                    HyperLink9.Visible = false;
                    HyperLink10.Visible = false;
                    HyperLink11.Visible = false;
                    HyperLink13.Visible = false;
                    HyperLink3.Text = "Cart(" + cartcount + ")";
                    Username.Text = " | Hi, " + ((User)Session["user"]).Username;
                }
            }
            
        }

        protected void UserLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/User/Login.aspx");
        }
    }
}