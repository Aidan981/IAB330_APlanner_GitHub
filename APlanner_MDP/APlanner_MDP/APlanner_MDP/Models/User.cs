using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner_MDP.Models
{
    public class user
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public user()
        {
        }
        public user(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool UserAuthenticated(string username,string password)
        {
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
    }
}
