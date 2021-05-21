using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Handlers
{
    public static class UserHandler
    {
        public static Boolean usernameIsUnique(String username)
        {
            return Repositories.UserRepository.isUsernameUnique(username);
        }
        public static User getUserByUsernameAndPassword(String username, String password)
        {
            User user = Repositories.UserRepository.getUserByUsernameAndPassword(username, password);
            return user;
        }

        public static List<User> getUserFromServiceList(List<Service> services)
        {
            return Repositories.UserRepository.getUserFromServiceList(services);
        }

        public static Boolean phoneNumberIsUnique(string phoneNumber)
        {
            return Repositories.UserRepository.isPhoneNumberUnique(phoneNumber);
        }

        public static User getUserID(String userId)
        {
            User user = Repositories.UserRepository.getUserById(userId);
            return user;
        }

        public static Boolean emailIsUnique(String email)
        {
            return Repositories.UserRepository.isEmailUnique(email);
        }



        public static void insertUser(string username, string email, string password, string name, string phoneNumber, string gender, string userRole, string address, string profilePictureFilePath, string serviceName, string serviceType, string serviceDescription, int servicePrice)
        {
            if (userRole.Equals("RO001"))
            {
                Repositories.UserRepository.insertUser(username, email, password, name, phoneNumber, gender, userRole, address, "");
            }
            else
            {
                Repositories.UserRepository.insertUser(username, email, password, name, phoneNumber, gender, userRole, address, profilePictureFilePath);
                Repositories.ServiceRepository.insertService(serviceName, username, serviceType, serviceDescription, servicePrice);
            }
        }
    }
}