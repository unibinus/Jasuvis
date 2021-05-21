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
    }
}