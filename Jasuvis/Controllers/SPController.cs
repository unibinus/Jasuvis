using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Jasuvis.Controllers
{
    public class SPController
    {
        public static void serviceProviderData(User u, Repeater rep)
        {
            User user = Handlers.UserHandler.getUserID(u.UserID);
            Service service = Handlers.ServiceHandler.GetService(u);
            ServiceType serviceType = Handlers.ServiceTypeHandler.GetType(service);
            List<dynamic> recommendedList = new List<dynamic>();
            var newObj = new {
                serviceUserID = service.UserID,
                serviceTypeName = serviceType.ServiceTypeName,
                servicename = service.ServiceName,
                servicePrice = service.ServicePrice,
                serviceProviderName = user.Name,
                serviceProviderPhoto = user.ProfilePicture,
                serviceAddress = user.Address,
                serviceDescription = service.ServiceDescription
            };
            recommendedList.Add(newObj);
            rep.DataSource = recommendedList;
            rep.DataBind();
        }
    }
}