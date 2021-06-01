using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Handlers
{
    public static class ServiceTypeHandler
    {
        public static List<ServiceType> getServiceType()
        {
            return Repositories.ServiceTypeRepository.getServiceType();
        }

        public static List<ServiceType> getServiceTypeFromServiceList(List<Service> services)
        {
            return Repositories.ServiceTypeRepository.getServiceTypeFromServiceList(services);
        }

        public static ServiceType GetType()
        {
            return Repositories.ServiceTypeRepository.GetType();
        }
        public static string GetFirstType()
        {
            return Repositories.ServiceTypeRepository.getFirstType();
        }
    }
}