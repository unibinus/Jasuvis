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
        public static string getFirstType()
        {
            return (from serviceType in db.ServiceTypes select serviceType.ServiceTypeName).First();
        }
        public static List<ServiceType> getServiceTypeFromServiceList(List<Service> services)
        {
            List<ServiceType> serviceTypeList = new List<ServiceType>();
            foreach (Service service in services)
            {
                ServiceType st = (from serviceType in db.ServiceTypes where serviceType.ServiceTypeID.Equals(service.ServiceTypeID) select serviceType).FirstOrDefault();
                serviceTypeList.Add(st);
            }
            return serviceTypeList;
        }

        public static ServiceType GetType()
        {
            ServiceType st = (from serviceType in db.ServiceTypes
                              join s in db.Services on serviceType.ServiceTypeID equals s.ServiceTypeID
                              join u in db.Users on s.UserID equals u.UserID
                              where serviceType.ServiceTypeID.Equals(s.ServiceTypeID)
                              select serviceType).FirstOrDefault();
            return st;
        }
    }
}