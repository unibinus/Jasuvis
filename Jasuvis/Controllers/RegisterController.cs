using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Jasuvis.Controllers
{
    public static class RegisterController
    {
      

        public static void getServiceTypeData(DropDownList serviceTypeDDL)
        {
            List<ServiceType> serviceTypes = Handlers.ServiceTypeHandler.getServiceType();
            serviceTypeDDL.Items.Add(new ListItem("default", "Select Service Type"));
            foreach (ServiceType serviceType in serviceTypes)
            {
                serviceTypeDDL.Items.Add(new ListItem(serviceType.ServiceTypeName, serviceType.ServiceTypeID));
            }
            serviceTypeDDL.DataBind();
            serviceTypeDDL.SelectedIndex = 0;
        }


        private static String validateUsername(String username)
        {

            if (!uniqueUsername(username))
            {
                return "Sorry the username has been taken, try other username";
            }
            return "Success";
        }
        private static String validateEmail(String email)
        {
            
            if (!uniqueEmail(email))
            {
                return "Sorry the email has been taken";
            }
            return "Success";
        }

        private static String validatePhoneNumber(String phoneNumber)
        {
            if (!uniquePhoneNumber(phoneNumber))
            {
                return "Sorry the phone number already exist, please use another phone number";
            }
            return "Success";
        }

        public static string registerValidation(string username, string email, string password, string name, string phoneNumber, string gender, string userRole, string address, FileUpload kTPfile, FileUpload selfieKTPFile, FileUpload profilePictureFile, string serviceName, string serviceType, string serviceDescription, string servicePrice, HttpResponse Response)
        {
            String errorMsg = validateUsername(username);
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateEmail(email);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validatePhoneNumber(phoneNumber);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = "Validation Passed";
            }
            if (errorMsg.Equals("Validation Passed"))
            {
                if(userRole == "RO001")
                {
                    Handlers.UserHandler.insertUser(username, email, password, name, phoneNumber, gender, userRole, address, "", "", "", "", 0);

                }
                else
                {
                    String KTPpictureFilePath = getKTPFilePath(kTPfile);
                    String profilePictureFilePath = getProfilePictureFilePath(profilePictureFile);
                    String SelfieKTPFilePath = getSelfieKTPFilePath(selfieKTPFile);
                    
                    Handlers.UserHandler.insertUser(username, email, password, name, phoneNumber, gender, userRole, address, profilePictureFilePath, serviceName, serviceType, serviceDescription, int.Parse(servicePrice));
                    saveFile(kTPfile, profilePictureFile, selfieKTPFile);
                }

                Response.Redirect("~/Views/LoginPage.aspx");
            }
            return errorMsg;
        }

        private static String getKTPFilePath(FileUpload KTPPictureFile)
        {
            return "~/Assets/ServiceProviderKTPPhoto/" + KTPPictureFile.FileName;
        }
        private static String getProfilePictureFilePath(FileUpload profilePictureFile)
        {
            return "~/Assets/ServiceProviderProfilePicture/" + profilePictureFile.FileName;
        }        
        private static String getSelfieKTPFilePath(FileUpload selfieKTPFile)
        {
            return "~/Assets/ServiceProviderSelfieKTP/" + selfieKTPFile.FileName;
        }

        private static void saveKTPPhoto(FileUpload KTPPictureFile)
        {
            String KTPFilePath = getKTPFilePath(KTPPictureFile);
            var filePath = HttpContext.Current.Server.MapPath(KTPFilePath);
            HttpPostedFile File = KTPPictureFile.PostedFile;
            File.SaveAs(filePath);
        }
        private static void saveProfilePicture(FileUpload ProfilePictureFile)
        {
            String ProfilePictureFilePath = getProfilePictureFilePath(ProfilePictureFile);
            var filePath = HttpContext.Current.Server.MapPath(ProfilePictureFilePath);
            HttpPostedFile File = ProfilePictureFile.PostedFile;
            File.SaveAs(filePath);
        }        
        private static void saveSelfieKTPPicture(FileUpload selfieKTPFile)
        {
            String selfieKTPFilePath = getSelfieKTPFilePath(selfieKTPFile);
            var filePath = HttpContext.Current.Server.MapPath(selfieKTPFilePath);
            HttpPostedFile File = selfieKTPFile.PostedFile;
            File.SaveAs(filePath);
        }

        private static void saveFile(FileUpload KTPPictureFile, FileUpload profilePictureFile, FileUpload selfieKTPFile)
        {
            saveKTPPhoto(KTPPictureFile);
            saveProfilePicture(profilePictureFile);
            saveSelfieKTPPicture(selfieKTPFile);
        }

        private static Boolean uniqueEmail(String email)
        {
            return Handlers.UserHandler.emailIsUnique(email);
        }
        private static Boolean uniqueUsername(String username)
        {
            return Handlers.UserHandler.usernameIsUnique(username);
        }
        private static Boolean uniquePhoneNumber(String phoneNumber)
        {
            return Handlers.UserHandler.phoneNumberIsUnique(phoneNumber);
        }
    }
}