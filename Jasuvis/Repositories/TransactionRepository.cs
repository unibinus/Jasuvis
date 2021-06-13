using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jasuvis.Models;

namespace Jasuvis.Repositories
{
    public class TransactionRepository
    {
        private static JasuvisDBEntities5 db = Repositories.JasuvisDBSingleton.getDBInstance();
        private static String generateTransactionID()
        {
            String lastUserId = (from transaction in db.Transactions select transaction.TransactionID).ToList().LastOrDefault();
            if (lastUserId == null)
            {
                return "TR001";
            }
            else
            {
                int Id = int.Parse(lastUserId.Substring(2));
                Id++;
                return String.Format("{0}{1:000}", "TR", Id);
            }
        }
        public static void insertTransaction(User u, Service s, DateTime time)
        {
            String TransactionID = generateTransactionID();
            Transaction transaction = Factories.TransactionFactory.createTransaction(TransactionID, u, s, time);
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public static List<Transaction> getTR()
        {
            List<Transaction> t = (from transaction in db.Transactions select transaction).OrderBy(o => Guid.NewGuid()).ToList();
            return t;
        }
    }
}