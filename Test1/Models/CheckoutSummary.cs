using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class CheckoutSummary
    {
        public Collection CollectionInformation { get; set; }
        public Delivery DeliveryInformation { get; set; }
        public Parcel ParcelInformation { get; set; }
        public string ServiceInformation { get; set; }
    }
}
