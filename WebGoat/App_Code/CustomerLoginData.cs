using System;
using System.Collections.Generic;
using System.Web;

namespace OWASP.WebGoat.NET
{
    public class CustomerLoginData
    {
        private string token = "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";
        public string email = string.Empty;
        public string password = string.Empty;
        public bool isLoggedIn = false;
        public string message = string.Empty;

        public CustomerLoginData(string email, string password, bool isLoggedIn)
        {
            this.email = email;
            this.password = password;
            this.isLoggedIn = isLoggedIn;
        }
        public String Message
        {
            get
            {
                return this.message;
            }
            set
            {
                value = message;
            }
        }

    }
}
