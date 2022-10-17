using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public Address DeliveryAddress { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string DeliveryContactName { get; set; }

        public string ContactNumber { get; set; }
    }
}
