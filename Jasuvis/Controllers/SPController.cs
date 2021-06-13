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
            var newObj = new
            {
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
        public static void serviceTransaction(User u, Repeater rep)
        {
            User user = Handlers.UserHandler.getUserID(u.UserID);
            List<Transaction> transactions = Handlers.TransactionHandler.getTR();

            List<dynamic> recommendedList = new List<dynamic>();
            List<dynamic> TRList = new List<dynamic>();
            List<Service> s = new List<Service>();
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i].UserID == u.UserID)
                {
                    var tr = transactions[i];
                    TRList.Add(tr);
                }

            }
            for (int i = 0; i < TRList.Count; i++)
            {
                string id = TRList[i].ServiceID;
                Service st = Handlers.ServiceHandler.GetServiceByID(id);
                User us = Handlers.UserHandler.getUserID(st.UserID);
                ServiceType serviceType = Handlers.ServiceTypeHandler.GetType(st);
                var newObject = new
                {
                    transactionID = TRList[i].TransactionID,
                    serviceProviderName = st.ServiceName,
                    serviceProviderPhoto = us.ProfilePicture,
                    serviceTypeName = serviceType.ServiceTypeName,
                    transactionDate = TRList[i].TransactionDate,
                };
                recommendedList.Add(newObject);

            }
            rep.DataSource = recommendedList;
            rep.DataBind();
        }
    }
}