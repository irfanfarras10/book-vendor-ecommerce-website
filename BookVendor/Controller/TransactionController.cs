using BookVendor.Handler;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Controller
{
    public class TransactionController
    {
        public static List<HeaderTransaction> getUserTransaction(int userid)
        {
            return TransactionHandler.getUserTransaction(userid);
        }

        public static List<HeaderTransaction> getAllTransaction()
        {
            return TransactionHandler.getAllTransaction();
        }

    }
}