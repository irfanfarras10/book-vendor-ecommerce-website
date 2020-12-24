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
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            crview.ReportSource = cr;
            List<HeaderTransaction> ht = TransactionController.getAllTransaction();
            DataSet1 ds = getdata(ht);
            cr.SetDataSource(ds);
        }

        private DataSet1 getdata(List<HeaderTransaction> HeaderTransaction)
        {
            DataSet1 ds = new DataSet1();
            var Headertable = ds.HeaderTransaction;
            var Detailtable = ds.DetailTransaction;
            foreach(HeaderTransaction ht in HeaderTransaction)
            {
                var htrow = Headertable.NewRow();
                htrow["TransactionID"] = ht.TransactionID;
                htrow["UserID"] = ht.UserID;
                htrow["Username"] = ht.User.Username;
                htrow["Date"] = ht.Date;
                Headertable.Rows.Add(htrow);
                foreach(DetailTransaction dt in ht.DetailTransactions)
                {
                    var dtrow = Detailtable.NewRow();
                    dtrow["TransactionID"] = ht.TransactionID;
                    dtrow["Name"] = dt.Book.Name;
                    dtrow["Price"] = dt.Book.Price;
                    dtrow["Quantity"] = dt.Quantity;
                    Detailtable.Rows.Add(dtrow);
                }
            }
            return ds;
        }

    }
}