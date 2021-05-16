using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Controllers
{
    public static class RegisterController
    {
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

        public static String registerValidation(String email, String password, Boolean isServiceProvider, Boolean isNotServiceProvider, String name, Boolean genderMaleChosen, Boolean genderFemaleChosen, String phoneNumber, String Address, HttpResponse Response)
        {
            String errorMsg = validateEmail(email);
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
                errorMsg = validateRole(isServiceProvider, isNotServiceProvider);
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
                errorMsg = "Registration Success";
            }
            if (errorMsg.Equals("Registration Success"))
            {
                String role = "";
                if(isNotServiceProvider){
                    role = "RO001";
                }
                else
                {
                    role = "RO002";
                }
                if (genderMaleChosen)
                {
                    Handlers.UserHandler.insertUser(email, password, role, name, "M", phoneNumber, Address);
                }
                else
                {
                    Handlers.UserHandler.insertUser(email, password, role, name, "F", phoneNumber, Address);
                }
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            return errorMsg;
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