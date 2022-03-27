using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class Dator : Products
    {


        public Dator( string Description, int Value, int AmountOf)
        {
            this.Discription = Description;
            this.Value = Value;
            this.AmountOf = AmountOf;
        }
    }
}
