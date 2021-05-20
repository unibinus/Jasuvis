using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Factories
{
    public static class ServiceFactory
    {
        private static JasuvisDBEntities5 db = Repositories.JasuvisDBSingleton.getDBInstance();
        public static Service createService(String serviceID, String userID, String serviceName, String serviceType, String serviceDescription, int servicePrice)
        {
            Service service = new Service();
            service.ServiceID = serviceID;
            service.UserID = userID;
            service.ServiceTypeID = serviceType;
            service.ServiceDescription = serviceDescription;
            service.ServicePrice = servicePrice;
            return service;
        }
    }
}