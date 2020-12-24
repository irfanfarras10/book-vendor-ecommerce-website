using BookVendor.Controller;
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
    public partial class AddtoCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["BookID"] != null)
            {
                int BookID = Int32.Parse(Request.QueryString["BookID"]);
                DataList.DataSource = BookController.getSingle(BookID);
                DataList.DataBind();
            }
        }

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int userid = ((User)Session["user"]).UserID;
            string qty = ((TextBox)e.Item.FindControl("qty")).Text;
            int id = Int32.Parse(e.CommandArgument.ToString());
            Label lbl = (Label)e.Item.FindControl("validator");
            string stock = ((Label)e.Item.FindControl("stock")).Text;
            int cartqty = CartController.cartqty(id);
            if (qty == null || qty == "")
            {
                lbl.Text = "Tidak boleh kosong";
                return;
            }

            int qty1 = Int32.Parse(qty);
            int stock1 = Int32.Parse(stock);

            if (qty1 < 1)
            {
                lbl.Text = "Harus diantara 1 dan " + stock;
            }
            else if (qty1 > stock1)
            {
                lbl.Text = "Stock tidak tersedia";
            }
            else if ((qty1+cartqty) > stock1 )
            {
                lbl.Text = "Jumlah yang dimasukkan dan jumlah yang dipesan dalam cart lain telah melebihi stock buku yang saat ini dipilih.";
            }
            else
            {
                Book book = BookController.find(Int32.Parse(e.CommandArgument.ToString()));
                bool Exist = false;
                if(CartController.GetCart(userid).Count != 0)
                {
                    if(CartController.Sumqty(userid,id,qty1) != null)
                    {
                        Exist = true;
                    }
                }
                if(!Exist || CartController.GetCart(userid).Count == 0)
                {
                    CartController.insertCart(userid,id,qty1);
                }
                lbl.Text = "";
                Response.Redirect("CartPage.aspx");
            }

        }



    }
}