using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Repositories
{
    public static class ServiceRepository
    {
        private static JasuvisDBEntities5 db = Repositories.JasuvisDBSingleton.getDBInstance();
        private static String generateServiceID()
        {
            String lastServiceId = (from service in db.Services select service.ServiceID).ToList().LastOrDefault();
            if (lastServiceId == null)
            {
                return "SE001";
            }
            else
            {
                int Id = int.Parse(lastServiceId.Substring(2));
                Id++;
                return String.Format("{0}{1:000}", "SE", Id);
            }
        }

        private static String getUserID(String username)
        {
            User user = Repositories.UserRepository.getUserByUsername(username);
            return user.UserID;
        }
        public static void insertService(String serviceName, String username, String serviceType, String serviceDescription, int servicePrice)
        {
            String serviceID = generateServiceID();
            Service service = Factories.ServiceFactory.createService(serviceID, getUserID(username), serviceName, serviceType, serviceDescription, servicePrice);
            db.Services.Add(service);
            db.SaveChanges();
        }
    
        public static List<Service> getRecommendedService()
        {
            Random rand = new Random();

            List<Service> s = (from service in db.Services select service).OrderBy(o => Guid.NewGuid()).Take(4).ToList();
            return s;
        }

        public static List<Service> getSP()
        {
            List<Service> s = (from service in db.Services select service).OrderBy(o => Guid.NewGuid()).ToList();
            return s;
        }

        public static Service GetService()
        {
            Service s = ((from service in db.Services
                         join user in db.Users on service.UserID equals user.UserID
                         where service.UserID.Equals(user.UserID)
                         select service)).FirstOrDefault();
            return s;
        }

    }
}