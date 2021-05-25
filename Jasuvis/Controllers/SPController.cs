using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Controllers
{
    public class SPController
    {
        public static void serviceProviderData(User u)
        {
            User user = Handlers.UserHandler.getUserID(u.UserID);
            Service service = Handlers.ServiceHandler.GetService();
            ServiceType serviceType = Handlers.ServiceTypeHandler.GetType();

            var newObj = new {
                serviceUserID = service.UserID,
                serviceTypeName = serviceType.ServiceTypeName,
                servicename = service.ServiceName,
                serviceProviderName = user.Name,
                serviceProviderPhoto = user.ProfilePicture
            };

        }
    }
}