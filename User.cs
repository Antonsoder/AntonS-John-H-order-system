using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public bool LoginStatus { get; set; }

        public void verifyLogin(string name, string Password)
        {
            if (name == this.Name && Password == this.Password)
            {
                this.LoginStatus = true;
            }
        }

    }
}