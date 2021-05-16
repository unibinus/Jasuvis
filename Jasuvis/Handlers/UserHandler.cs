using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Handlers
{
    public static class UserHandler
    {
        public static User getUserByUsernameAndPassword(String email, String password)
        {
            User user = Repositories.UserRepository.getUserByEmailAndPassword(email, password);
            return user;
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

        //public static void insertUser(String username, String password, String name, String gender, String phoneNumber, String address)
        //{
        //    Repositories.UserRepository.insertUser(username, password, name, gender, phoneNumber, address);
        //}
    }
}