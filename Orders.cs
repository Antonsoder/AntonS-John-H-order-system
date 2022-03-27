using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{
    class Orders
    {
        public List<OrderDetails> aOrderDetails = new List<OrderDetails>();
        public string DateCreated { get; set; }

        public string DateShipped { get; set; }

        public string CustomerName { get; set; }

        public string Status { get; set; }

        public int CartId { get; set; }

        public int CustomerId { get; set; }

        public int ShippingId { get; set; }

        public Orders(string DateShipped, string CustomerName, string Status, int CartID, int CustomerId, int ShippingId)
        {
            this.DateShipped = DateShipped;
            this.CustomerName = CustomerName;
            this.Status = Status;
            this.CartId = CartID;
            this.CustomerId = CustomerId;
            this.ShippingId = ShippingId;
        }

    }

}
