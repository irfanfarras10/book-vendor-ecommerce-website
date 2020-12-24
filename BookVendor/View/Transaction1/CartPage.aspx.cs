using BookVendor.Controller;
using BookVendor.Handler;
using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookVendor.View.Transaction1
{
    public partial class CartPage : System.Web.UI.Page
    {
        int userid;
        protected void Page_Load(object sender, EventArgs e)
        {           
            if(Session["user"]!=null) userid = ((User)Session["user"]).UserID;
            if (CartController.GetCart(userid).Count!= 0)
            {
                cekout.Visible = true;
                total.Text = "Total: " + CartController.Total(userid);
            }
            else
            {
                cekout.Visible = false;
                total.Text = "Tidak ada item diCart";
            }
            Grid1.DataSource = CartController.GetCart(userid);
            Grid1.DataBind();
        }

        protected void cekout_Click(object sender, EventArgs e)
        {
            TransactionHandler.Checkout((User)Session["user"]);
            CartController.delAll(userid);
            Response.Redirect("CartPage.aspx");
        }

        protected void Grid1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteItem")
            {
                int id = Int32.Parse(e.CommandArgument.ToString());
                CartController.delete1(id);
                Grid1.DataSource = CartController.GetCart(userid);
                Grid1.DataBind();
            }
        }
    }
}