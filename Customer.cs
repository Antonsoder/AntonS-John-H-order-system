using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class Customer : User
    {

        public string Address { get; set; }

        public string Email { get; set; }

        public string CreditCardInfo { get; set; }

        public string användarNamn { get; set; }

        public void logIn(string lösen, string aanvändarNamn)
        {
            if (lösen == Password && aanvändarNamn == användarNamn)
            {
                Console.WriteLine("Du är inloggad");
            }
        }

        public Customer(string CustomerName, string Address, string Email, string CreditCardI, string användarnamn, string lösen)
        {
            this.Name = CustomerName;
            this.Address = Address;
            this.Email = Email;
            this.CreditCardInfo = CreditCardI;
            this.användarNamn = användarnamn;
            this.Password = lösen;
        }

    }
}