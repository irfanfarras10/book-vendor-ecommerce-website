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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataList.DataSource = BookController.GetRandomBook();
                DataList.DataBind();
            }
            String role = ((User)Session["user"]).Role.RoleName;
            if (role == "Administrator")
            {
                ibook.Visible = true;
                vbook.Visible = true;
                vuser.Visible = true;
                vprofile.Visible = true;
                vgenre.Visible = true;
                igenre.Visible = true;
                vreport.Visible = true;
                vcart.Visible = false;
                vtrans.Visible = false;
            }
            else if(role=="Member")
            {
                vbook.Visible = true;
                vcart.Visible = true;
                vtrans.Visible = true;
                vprofile.Visible = true;
                ibook.Visible = false;
                vuser.Visible = false;
                vgenre.Visible = false;
                igenre.Visible = false;
                vreport.Visible = false;
            }
            else
            {
                ibook.Visible = false;
                vuser.Visible = false;
                vgenre.Visible = false;
                igenre.Visible = false;
                vreport.Visible = false;
                vbook.Visible = false;
                vcart.Visible = false;
                vtrans.Visible = false;
                vprofile.Visible = false;
            }

        }

        protected void vbook_Click(object sender, EventArgs e)
        {
            String role = ((User)Session["user"]).Role.RoleName;
            if (role == "Member") Response.Redirect("Book/ViewBook.aspx");
            else if (role == "Administrator") Response.Redirect("Book/UpdateBook.aspx");
        }

        protected void vprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("User/ViewProfile.aspx");
        }

        protected void vcart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction1/CartPage.aspx");
        }

        protected void vtrans_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction1/ViewTransactionHistory.aspx");
        }

        protected void ibook_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book/InsertBook.aspx");
        }

        protected void vuser_Click(object sender, EventArgs e)
        {
            Response.Redirect("User/ViewUser.aspx");
        }

        protected void vgenre_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book/UpdateGenre.aspx");
        }

        protected void igenre_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book/InsertGenre.aspx");
        }

        protected void vreport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction1/TransactionReport.aspx");
        }

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "buy")
            {
                int BookID = Int32.Parse(e.CommandArgument.ToString());
                Response.Redirect("Transaction1/AddtoCart.aspx?BookID=" + BookID);
            }
        }

        protected void DataList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            LinkButton buy = (LinkButton)e.Item.FindControl("add");
            String role = ((User)Session["user"]).Role.RoleName;
            if (role == "Administrator") buy.Visible = false;
            else if (role == "Member") buy.Visible = true;
            else buy.Visible = false;
        }
    }
}