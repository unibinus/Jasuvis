﻿using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Jasuvis.Handlers;

namespace Jasuvis.Controllers
{
    public static class AuthenticationController
    {
        private static String validateEmail(String email)
        {
            if (email.Contains("@") && email.Contains(".") &&
              !email.StartsWith("@") && !email.EndsWith("@") &&
              !email.StartsWith(".") && !email.EndsWith(".") &&
              Math.Abs(email.IndexOf('@') - email.IndexOf('.')) != 1)
            {
                return "Success";
            }

            return "Invalid Email";
        }
        private static String validatePassword(String password)
        {
            if (String.IsNullOrWhiteSpace(password))
            {
                return "Password cannot be empty!";
            }
            return "Success";
        }

        public static String userLoginAuthentication(String email, String password, Boolean userCheckRememberMe, HttpSessionState Session, HttpResponse Response)
        {
            User user = null;
            String errorMsg = validateEmail(email);

            if (errorMsg.Equals("Success"))
            {
                errorMsg = validatePassword(password);
            }
            if (errorMsg.Equals("Success"))
            {
                user = Handlers.UserHandler.getUserByUsernameAndPassword(email, password);
                if (user == null)
                {
                    errorMsg = "Email and password combination did not match";
                }
                else
                {
                    errorMsg = "Success Login";
                }
            }
            if (errorMsg.Equals("Success Login"))
            {
                if (userCheckRememberMe)
                {
                    HttpCookie cookie = new HttpCookie("LoginCookie");
                    cookie.Value = user.UserID;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Session["UserLoggedin"] = user;
                Response.Redirect("~/Views/HomePage.aspx");
            }
            return errorMsg;
        }
        public static User getCookie(HttpRequest Request)
        {
            if (Request.Cookies.Get("LoginCookie") != null)
            {
                String userId = Request.Cookies.Get("LoginCookie").Value;
                User user = Repositories.UserRepository.getUserById(userId);
                return user;
            }
            return null;
        }

        public static String getEmailFromCookie(HttpRequest Request)
        {
            User user = getCookie(Request);
            if (user != null)
            {
                return user.Email;

            }
            return "";
        }
        public static String getPasswordFromCookie(HttpRequest Request)
        {
            User user = getCookie(Request);
            if (user != null)
            {
                return user.Password;
            }
            return "";
        }
    }
}