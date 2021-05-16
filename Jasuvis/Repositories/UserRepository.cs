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
    }
}