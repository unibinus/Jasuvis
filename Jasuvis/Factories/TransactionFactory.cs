using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jasuvis.Models;

namespace Jasuvis.Factories
{
    public class TransactionFactory
    {
        public static Transaction createTransaction(String TransactionID, User u, Service s, DateTime time)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionID = TransactionID;
            transaction.UserID = u.UserID;
            transaction.ServiceID = s.ServiceID;
            transaction.TransactionDate = time;

            return transaction;
        }
    }
}