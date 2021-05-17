using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Factories
{
    public static class UserFactory
    {
        public static User createUser(String userID, String username, String email, String password, String role, String name, String gender, String phoneNumber, String address, String pictureFilePath)
        {
            User newUser = new User();
            newUser.UserID = userID;
            newUser.Username = username;
            newUser.Email = email;
            newUser.Password = password;
            newUser.RoleID = role;
            newUser.Name = name;
            newUser.Gender = gender;
            newUser.PhoneNumber = phoneNumber;
            newUser.Address = address;
            newUser.ProfilePicture = pictureFilePath;
            return newUser;
        }
    }
}