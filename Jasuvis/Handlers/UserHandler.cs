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

        public static User getUserID(String userId)
        {
            User user = Repositories.UserRepository.getUserById(userId);
            return user;
        }

        public static Boolean emailIsUnique(String email)
        {
            return Repositories.UserRepository.isEmailUnique(email);
        }

        public static void insertUser(String username, String email, String password, String role, String name, String gender, String phoneNumber, String address, String pictureFilePath)
        {
            Repositories.UserRepository.insertUser(username, email, password, role , name, gender, phoneNumber, address, pictureFilePath);
        }
    }
}