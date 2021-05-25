using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Jasuvis.Models;

namespace Jasuvis.Controllers
{
    public class ExploreController
    {
        public static void serviceProviderData(Repeater spData)
        {
            List<Service> services = Handlers.ServiceHandler.getSP();
            List<User> serviceProvider = Handlers.UserHandler.getUserFromServiceList(services);
            List<ServiceType> serviceTypes = Handlers.ServiceTypeHandler.getServiceTypeFromServiceList(services);

            List<dynamic> recommendedList = new List<dynamic>();
            for (int i = 0; i < serviceProvider.Count; i++)
            {
                var newObject = new
                {
                    serviceUserID = services[i].UserID,
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
            spData.DataSource = recommendedList;
            spData.DataBind();
        }

        internal static void serviceProviderData(object spData)
        {
            throw new NotImplementedException();
        }
    }
}