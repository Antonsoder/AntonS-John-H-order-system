using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{

    class Program
    {
        static void Main(string[] args)
        {
            bool pProgram = true;
            Amazon amazon = new Amazon(1, "AmazoneAntJohn");
            Administrator admin1 = new Administrator("John", "John@Gmail.com", "1234");
            amazon.aAdministrator.Add(admin1);
            Console.WriteLine("hejsan");

            while (pProgram == true)
            {
                Console.WriteLine("vill du vara \n 1. Administrator \n 2. Customer");
                int hejsan = int.Parse(Console.ReadLine());
                switch (hejsan)
                {
                    case 1:
                        Console.WriteLine(" Vill du skapa en admin 1. \n eller interagera 2.");
                        hejsan = int.Parse(Console.ReadLine());
                        switch (hejsan)
                        {
                            case 1:
                                Console.WriteLine("Skriv dina uppgifter så här namn och sedan Email till sist lösenord: ");
                                string namn = Console.ReadLine();
                                string Email = Console.ReadLine();
                                string password = Console.ReadLine();
                                Administrator admin = new Administrator(namn, Email, password);
                                amazon.aAdministrator.Add(admin);
                                foreach (var Administrator in amazon.aAdministrator)
                                {
                                    Console.WriteLine(Administrator.Name);
                                    Console.WriteLine(Administrator.AdminEmail);
                                    Console.WriteLine("----------------------");
                                }
                                break;
                            case 2:

                                Console.WriteLine("Vem är det som handlar in? skriv även sedan lösenord");
                                string vem1 = Console.ReadLine();
                                string Lösenord1 = Console.ReadLine();
                                foreach (var vem in amazon.aAdministrator)
                                {
                                    vem.verifyLogin(vem1, Lösenord1);
                                    if (vem.LoginStatus == true)
                                    {
                                        Console.WriteLine($"Hejsan {vem1}");
                                        Console.WriteLine("Vill du handla in: \n 1. Äpple \n 2. Iphone \n 3. Dator");
                                        hejsan = int.Parse(Console.ReadLine());
                                        switch (hejsan)
                                        {
                                            case 1:
                                                Console.WriteLine("Skriv description, värde och mängd");
                                                string Underlag = Console.ReadLine();
                                                int värde = int.Parse(Console.ReadLine());
                                                int antal = int.Parse(Console.ReadLine());
                                                Äpple äpple = new Äpple(Underlag, värde, antal);
                                                admin1.aÄpple.Add(äpple);
                                                foreach (var aäpple in admin1.aÄpple)
                                                {
                                                    Console.WriteLine(aäpple.Discription);
                                                    Console.WriteLine(aäpple.Value);
                                                    Console.WriteLine(aäpple.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            case 2:
                                                Console.WriteLine("Skriv description, värde och mängd");
                                                string Underlag1 = Console.ReadLine();
                                                int värde1 = int.Parse(Console.ReadLine());
                                                int antal1 = int.Parse(Console.ReadLine());
                                                Iphone iphone = new Iphone(Underlag1, värde1, antal1);
                                                admin1.aIphone.Add(iphone);
                                                foreach (var aiphone in admin1.aIphone)
                                                {
                                                    Console.WriteLine(aiphone.Discription);
                                                    Console.WriteLine(aiphone.Value);
                                                    Console.WriteLine(aiphone.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            case 3:
                                                Console.WriteLine("Skriv description, värde och mängd");
                                                string Underlag2 = Console.ReadLine();
                                                int värde2 = int.Parse(Console.ReadLine());
                                                int antal2 = int.Parse(Console.ReadLine());
                                                Dator dator = new Dator(Underlag2, värde2, antal2);
                                                /*foreach (var datorer in admin1.aDator)
                                                {
                                                    if (Underlag2 == datorer.Discription)
                                                    {
                                                        datorer.AmountOf = datorer.AmountOf + antal2;
                                                    }
                                                    else
                                                    {
                                                        Dator dator = new Dator(Underlag2, värde2, antal2);
                                                        admin1.aDator.Add(dator);
                                                    }
                                                }*/
                                                admin1.aDator.Add(dator);
                                                foreach (var adator in admin1.aDator)
                                                {
                                                    Console.WriteLine(adator.Discription);
                                                    Console.WriteLine(adator.Value);
                                                    Console.WriteLine(adator.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            default:
                                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Denna admin finns ej eller så var lösenordet fel");
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Skall det vara \n1. Skapa costumer \n2. handla som en costumer");
                        hejsan = int.Parse(Console.ReadLine());
                        switch (hejsan)
                        {
                            case 1:
                                Console.WriteLine("Skriv dina uppgifter i denna ordning: namn, adress, email, kredikortnummer, användarnamn och lösenord");
                                string namn = Console.ReadLine();
                                string adress = Console.ReadLine();
                                string email = Console.ReadLine();
                                string kreditkort = Console.ReadLine();
                                string användarnamn = Console.ReadLine();
                                string lösen = Console.ReadLine();
                                Customer customer = new Customer(namn, adress, email, kreditkort, användarnamn, lösen);
                                amazon.aCustomers.Add(customer);
                                Console.WriteLine("Du har nu gjort din costumer! Dessa är vilka som finns");
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    Console.WriteLine(acustom.Name);
                                    Console.WriteLine(acustom.Address);
                                    Console.WriteLine(acustom.Email);
                                    Console.WriteLine(acustom.CreditCardInfo);
                                    Console.WriteLine(acustom.användarNamn);
                                    Console.WriteLine(acustom.Password);
                                    Console.WriteLine("-------------------------");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Du måste identifiera dig innan du kan handla, skriv ditt användarnamn och lösenord");
                                användarnamn = Console.ReadLine();
                                lösen = Console.ReadLine();
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    if (användarnamn == acustom.användarNamn && lösen == acustom.Password)
                                    {
                                        Console.WriteLine($"välkomen {användarnamn} eller {acustom.Name}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fel användarnamn eller lösenord");
                                    }
                                }
                                Console.WriteLine("vad vill du handla \n1. Dator \n2.Iphone \n3. Äpple");
                                hejsan = int.Parse(Console.ReadLine());
                                switch (hejsan)
                                {
                                    case 1:
                                        Console.WriteLine("Ok! vilken typ av dator vill du ha? det finns: ");
                                        foreach (var Datorer in admin1.aDator)
                                        {
                                            Console.WriteLine(Datorer.Discription);
                                        }
                                        string Vilkentyp = Console.ReadLine();
                                        Console.WriteLine("Hur många datorer vill du ha?");
                                        int antal = int.Parse(Console.ReadLine());
                                        foreach (var aDatorer in admin1.aDator)
                                        {
                                            if (aDatorer.Discription == Vilkentyp)
                                            {
                                                if (aDatorer.AmountOf >= antal)
                                                {
                                                    aDatorer.AmountOf = aDatorer.AmountOf - antal;
                                                    Console.WriteLine($"Du köpte {antal}st {aDatorer.Discription} därmed finns det bara kvar {aDatorer.AmountOf} Detta kostade {aDatorer.Value}");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Tyvärr så har vi inte så många {aDatorer.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                }
                                            }

                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Ok! vilken typ av Iphone vill du ha? det finns: ");
                                        foreach (var Iphones in admin1.aIphone)
                                        {
                                            Console.WriteLine(Iphones.Discription);
                                        }
                                        Vilkentyp = Console.ReadLine();
                                        Console.WriteLine("Hur många Iphones vill du ha?");
                                        antal = int.Parse(Console.ReadLine());
                                        foreach (var aIphones in admin1.aÄpple)
                                        {
                                            if (aIphones.Discription == Vilkentyp)
                                            {
                                                if (aIphones.AmountOf >= antal)
                                                {
                                                    aIphones.AmountOf = aIphones.AmountOf - antal;
                                                    Console.WriteLine($"Du köpte {antal}st {aIphones.Discription} därmed finns det bara kvar {aIphones.AmountOf} Detta kostade {aIphones.Value}");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Tyvärr så har vi inte så många {aIphones.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                }
                                            }

                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Ok! vilken typ av äpple vill du ha? det finns: ");
                                        foreach (var äpplee in admin1.aÄpple)
                                        {
                                            Console.WriteLine(äpplee.Discription);
                                        }
                                        Vilkentyp = Console.ReadLine();
                                        Console.WriteLine("Hur många Äpplen vill du ha?");
                                        antal = int.Parse(Console.ReadLine());
                                        foreach (var aÄpple in admin1.aÄpple)
                                        {
                                            if (aÄpple.Discription == Vilkentyp)
                                            {
                                                if (aÄpple.AmountOf >= antal)
                                                {
                                                    aÄpple.AmountOf = aÄpple.AmountOf - antal;
                                                    Console.WriteLine($"Du köpte {antal}st {aÄpple.Discription} därmed finns det bara kvar {aÄpple.AmountOf} Detta kostade {aÄpple.Value}");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Tyvärr så har vi inte så många {aÄpple.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                }
                                            }

                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                        break;

                }
            }
        }
    }
}