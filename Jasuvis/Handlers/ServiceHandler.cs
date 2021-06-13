using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jasuvis.Models;
namespace Jasuvis.Handlers
{
    public static class ServiceHandler
    {
        public static List<Service> getRecommendedService()
        {
            return Repositories.ServiceRepository.getRecommendedService();
        }

        public static List<Service> getSP()
        {
            return Repositories.ServiceRepository.getSP();
        }

        public static Service GetService()
        {
            return Repositories.ServiceRepository.GetService();
        }
        public static Service GetService(User u)
        {
            return Repositories.ServiceRepository.GetService(u);
        }
        public static Service GetServiceByID(String id)
        {
            return Repositories.ServiceRepository.getServiceById(id);
        }
    }
}