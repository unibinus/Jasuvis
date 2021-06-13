using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jasuvis.Models;

namespace Jasuvis.Handlers
{
    public class TransactionHandler
    {
        public static void insertTransaction(User u, Service s, DateTime time)
        {
            Repositories.TransactionRepository.insertTransaction(u, s, time);
        }

        public static List<Transaction> getTR()
        {
            return Repositories.TransactionRepository.getTR();
        }
    }
}