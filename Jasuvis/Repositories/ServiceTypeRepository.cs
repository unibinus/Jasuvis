using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Repositories
{
    public static class ServiceTypeRepository
    {
        private static JasuvisDBEntities5 db = Repositories.JasuvisDBSingleton.getDBInstance();
        public static List<ServiceType> getServiceType()
        {
            return (from serviceType in db.ServiceTypes select serviceType).ToList();
        }
    }
}