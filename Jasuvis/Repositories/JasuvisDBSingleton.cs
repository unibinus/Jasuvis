using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Repositories
{
    public static class JasuvisDBSingleton
    {
        private static JasuvisDBEntities5 db = null;
        public static JasuvisDBEntities5 getDBInstance()
        {
            if(db == null)
            {
                return new JasuvisDBEntities5();
            }
            return db;
        }
    }
}