using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Jasuvis.Controllers
{
    public static class RegisterController
    {
        private static Boolean uniqueUsername(String username)
        {
            return Handlers.UserHandler.usernameIsUnique(username);
        }
        private static String validateUsername(String username)
        {
            if (isEmpty(username))
            {
                return "Username cannot be empty";
            }
            if (username.Length < 3)
            {
                return "Minimum username length is 3 characters";
            }
            if (!uniqueUsername(username))
            {
                return "Sorry the username has been taken, try other username";
            }
            return "Success";
        }
        private static String validateEmail(String email)
        {
            if (isEmpty(email))
            {
                return "Email cannot be empty!";
            }
            if (!email.Contains("@") && !email.Contains("."))
            {
                return "Email must contain \"@\" and \".\" ";
            }
            if (email.StartsWith("@"))
            {
                return "email cannot starts with \"@\"";
            }
            if (email.EndsWith("@"))
            {
                return "email cannot ends with \"@\"";
            }
            if (email.StartsWith("."))
            {
                return "email cannot starts with \".\"";
            }
            if (email.EndsWith("."))
            {
                return "email cannot ends with \".\"";
            }
            if (Math.Abs(email.IndexOf('@') - email.IndexOf('.')) == 1)
            {
                return "\"@\" and \".\" cannot be next to each other";
            }
            if (!uniqueEmail(email))
            {
                return "Sorry the email has been taken";
            }
            return "Success";
        }

        private static String validatePassword(String password)
        {
            if (isEmpty(password))
            {
                return "Password cannot be empty";
            }
            if (password.Length < 8)
            {
                return "Minimum password length is 8 characters";
            }
            return "Success";
        }

        private static String validateRole(Boolean isServiceProvider, Boolean isNotServiceProvider)
        {
            if(!isServiceProvider && !isNotServiceProvider)
            {
                return "Please confirm are you a service provider or not";
            }
            return "Success";
        }

        private static String validateName(String name)
        {
            if (isEmpty(name))
            {
                return "Name cannot be empty";
            }
            return "Success";
        }
        private static string validateGender(bool genderMale, bool genderFemale)
        {
            if (!genderMale && !genderFemale)
            {
                return "Must choose a gender";
            }
            return "Success";
        }

        private static String validatePhoneNumber(String phoneNumber)
        {
            if (isEmpty(phoneNumber))
            {
                return "Phone Number cannot be empty";
            }
            if (!phoneNumber.All(char.IsNumber))
            {
                return "Phone Number must be numeric";
            }
            return "Success";
        }

        private static String validateAddress(String address)
        {
            if (isEmpty(address))
            {
                return "Address cannot be empty";
            }
            if (!address.StartsWith("Jl. "))
            {
                return "Address must start with Jl.";
            }
            return "Success";
        }

        private static String validateProfilePicture(FileUpload pictureFile, Boolean hasUploadedFile)
        {
            var fileExtension = System.IO.Path.GetExtension(pictureFile.FileName);
            if (!hasUploadedFile)
            {
                return "Please insert a profile picture";
            }
            if(!fileExtension.Equals(".jpg") && !fileExtension.Equals(".png"))
            {
                return "File extension must be .jpg or .png ";
            }
            return "Success";
        }

        public static String registerValidation(String username, String email, String password, Boolean isServiceProvider, Boolean isNotServiceProvider, String name, Boolean genderMaleChosen, Boolean genderFemaleChosen, String phoneNumber, String Address, FileUpload pictureFile, Boolean hasUploadedFile, HttpResponse Response)
        {
            String errorMsg = validateUsername(username);
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateEmail(email);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validatePassword(password);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateName(name);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateGender(genderMaleChosen, genderFemaleChosen);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validatePhoneNumber(phoneNumber);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateAddress(Address);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateRole(isServiceProvider, isNotServiceProvider);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = validateProfilePicture(pictureFile, hasUploadedFile);
            }
            if (errorMsg.Equals("Success"))
            {
                errorMsg = "Registration Success";
            }
            if (errorMsg.Equals("Registration Success"))
            {
                String role = userRole(isServiceProvider);
                String gender = userGender(genderMaleChosen);
                String pictureFilePath = getFilePath(pictureFile);
                Handlers.UserHandler.insertUser(username, email, password, role, name, gender, phoneNumber, Address, pictureFilePath);
                saveFile(pictureFile);
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            return errorMsg;
        }
        private static String getFilePath(FileUpload pictureFile)
        {
            return "~/Assets/" + pictureFile.FileName;
        }
        private static void saveFile(FileUpload pictureFile)
        {
            String pictureFilePath = getFilePath(pictureFile);
            var filepath = HttpContext.Current.Server.MapPath(pictureFilePath);
            HttpPostedFile file = pictureFile.PostedFile;
            file.SaveAs(filepath);
        }
        private static String userGender(Boolean genderMaleChosen)
        {
            if (genderMaleChosen)
            {
                return "M";
            }
            return "F";
        }
        private static String userRole(Boolean isServiceProvider)
        {
            if (isServiceProvider)
            {
                return "RO002";
            }
            return "RO001";
        }
        private static Boolean isEmpty(String input)
        {
            return String.IsNullOrEmpty(input);
        }
        private static Boolean uniqueEmail(String email)
        {
            return Handlers.UserHandler.emailIsUnique(email);
        }
        

    }
}