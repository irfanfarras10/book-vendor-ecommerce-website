using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BookVendor.Model;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class ViewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataList.DataSource = BookController.GetAll();
                DataList.DataBind();
            }
            Clearbtn.Enabled = false;
        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            string name = Search.Text;
            if(BookController.getSearch(name) != null)
            {
                DataList.DataSource = BookController.getSearch(name);
                DataList.DataBind();
                empty.Text = "";
                Clearbtn.Enabled = true;
            }
            else
            {
                DataList.DataSource = BookController.GetAll();
                DataList.DataBind();
                empty.Text = "Buku tidak ditemukan";
            }            
        }

        protected void Clearbtn_Click(object sender, EventArgs e)
        {
            DataList.DataSource = BookController.GetAll();
            DataList.DataBind();
            empty.Text = "";
            Clearbtn.Enabled = false;
            Search.Text = "";
        }

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "buy")
            {
                int BookID = Int32.Parse(e.CommandArgument.ToString());
                Response.Redirect("~/View/Transaction1/AddtoCart.aspx?BookID=" + BookID);
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