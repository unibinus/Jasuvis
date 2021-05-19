using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jasuvis.Models;

namespace Jasuvis.Repositories
{
    public static class UserRepository
    {
        private static JasuvisDBEntities5 db = Repositories.JasuvisDBSingleton.getDBInstance();

        public static User getUserByUsernameAndPassword(String username, String password)
        {
            return (from user in db.Users
                    where user.Username.Equals(username) && user.Password.Equals(password)
                    select user).FirstOrDefault();
        }

        public static User getUserById(String userID)
        {
            return (from user in db.Users where user.UserID.Equals(userID) select user).FirstOrDefault();
        }

        public static Boolean isEmailUnique(String email)
        {
            User emailExist = (from user in db.Users where user.Email.Equals(email) select user).FirstOrDefault();
            return emailExist == null;
        }

        public static Boolean isUsernameUnique(String username)
        {
            User usernameExist = (from user in db.Users where user.Username.Equals(username) select user).FirstOrDefault();
            return usernameExist == null;
        }


        public static void insertUser(String username, String email, String password, String role, String name, String gender, String phoneNumber, String address, String pictureFilePath)
        {
            String userID = generateUserID();
            User user = Factories.UserFactory.createUser(userID, username, email, password, role, name, gender, phoneNumber, address, pictureFilePath);
            db.Users.Add(user);
            db.SaveChanges();
        }

        private static String generateUserID()
        {
            String lastUserId = (from user in db.Users select user.UserID).ToList().LastOrDefault();
            int Id = int.Parse(lastUserId.Substring(2));
            if (lastUserId == null)
            {
                return "US001";
            }
            else
            {
                Id++;
                return String.Format("{0}{1:000}", "US", Id);
            }
        }

        public static List<User> GetServiceProviders()
        {
            return (from sp in db.Users 
                    where sp.RoleID.Equals("RO002")
                    select sp).ToList();
        }

        public static List<ServiceType> GetServiceTypes()
        {
            return (from st in db.ServiceTypes join s in db.Services
                    on st.ServiceTypeID equals s.ServiceTypeID
                    join sp in db.Users
                    on s.UserID equals sp.UserID
                    where sp.RoleID.Equals("RO002")
                    select st).ToList();
        }
    }
}