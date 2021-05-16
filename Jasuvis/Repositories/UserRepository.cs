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

        public static User getUserByEmailAndPassword(String email, String password)
        {
            return (from user in db.Users
                    where user.Email.Equals(email) && user.Password.Equals(password)
                    select user).FirstOrDefault();
        }

        public static User getUserById(String userID)
        {
            return (from user in db.Users where user.UserID.Equals(userID) select user).FirstOrDefault();
        }

        public static Boolean isEmailUnique(String email)
        {
            User usernameExist = (from user in db.Users where user.Email.Equals(email) select user).FirstOrDefault();
            return usernameExist == null;
        }

        public static void insertUser(String email, String password, String role, String name, String gender, String phoneNumber, String address)
        {
            String userID = generateUserID();
            User user = Factories.UserFactory.createUser(userID, email, password, role, name, gender, phoneNumber, address);
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
    }
}