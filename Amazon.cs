using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class Amazon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> aCustomers { get; set; } = new List<Customer>();
        public List<Administrator> aAdministrator { get; set; } = new List<Administrator>();

        public Amazon(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
