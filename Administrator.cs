using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class Administrator : User
    {
        public string AdminEmail { get; set; }

        public List<Dator> aDator { get; set; } = new List<Dator>();

        public List<Iphone> aIphone { get; set; } = new List<Iphone>();

        public List<Äpple> aÄpple { get; set; } = new List<Äpple>();

        public Administrator(string AdminName, string AdminEmail, string password)
        {
            this.Name = AdminName;
            this.AdminEmail = AdminEmail;
            this.Password = password;
        }

        public void KöpaIn()
        {
            string Produkter = Console.ReadLine();

            if (Produkter == "Äpple")
            {
                Console.WriteLine("Skriv namn, Kostnad och mängd");
                Äpple äpple = new Äpple(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (Produkter == "Iphone")
            {
                Console.WriteLine("Skriv namn, Kostnad och mängd");
                Iphone Iphone = new Iphone(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (Produkter == "Dator")
            {
                Console.WriteLine("Skriv namn, Kostnad och mängd");
                Dator Dator = new Dator(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
        }
    }
}