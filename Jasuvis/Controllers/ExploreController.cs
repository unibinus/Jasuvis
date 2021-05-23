using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Jasuvis.Controllers
{
    public static class ExploreController
    {
        public static void ServiceProviderData(Repeater ServiceProviderData)
        {
            List<Service> services = Handlers.ServiceHandler.getRecommendedService();
            List<User> serviceProvider = Handlers.UserHandler.getUserFromServiceList(services);
            List<ServiceType> serviceTypes = Handlers.ServiceTypeHandler.getServiceTypeFromServiceList(services);
            
            List<dynamic> recommendedList = new List<dynamic>();
            for(int i = 0; i < serviceProvider.Count ; i++)
            {
                var newObject = new
                {
                    serviceTypeName = serviceTypes[i].ServiceTypeName,
                    servicename = services[i].ServiceName,
                    serviceProviderName = serviceProvider[i].Name,
                    serviceProviderPhoto = serviceProvider[i].ProfilePicture
                };
                recommendedList.Add(newObject);
            }
            //foreach (Service service in services)
            //{
            //    var newObject = new
            //    {
            //        serviceid = service.ServiceID,
            //        userid = service.UserID
            //    };
            //    newList.Add(newObject);
            //}
            ServiceProviderData.DataSource = recommendedList;
            ServiceProviderData.DataBind();
        }

        internal static void ServiceProviderData(object serviceProviderData)
        {
            throw new NotImplementedException();
        }
    }
}