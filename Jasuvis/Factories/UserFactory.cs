using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jasuvis.Factories
{
    public static class UserFactory
    {
        public static User createUser(String userID, string username, string email, string password, string name, string phoneNumber, string gender, string userRole, string address, string profilePictureFilePath)
        {
            User newUser = new User();
            newUser.UserID = userID;
            newUser.Username = username;
            newUser.Email = email;
            newUser.Password = password;
            newUser.RoleID = userRole;
            newUser.Name = name;
            newUser.Gender = gender;
            newUser.PhoneNumber = phoneNumber;
            newUser.Address = address;
            newUser.ProfilePicture = profilePictureFilePath;
            return newUser;
        }
    }
}