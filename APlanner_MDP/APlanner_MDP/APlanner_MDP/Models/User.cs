using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner_MDP.Models
{
    class user
    {
        private string text1;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public user(string text)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public user(string text, string text1) : this(text)
        {
            this.text1 = text1;
        }


        public bool UserAuthenticated()
        {



            if (string.IsNullOrEmpty(this.Username)
                || string.IsNullOrEmpty(this.Password))
            {
                return false;
            }

            return this.Username.ToLowerInvariant() == "joe"
                && this.Password.ToLowerInvariant() == "secret";
        }
    }
}
