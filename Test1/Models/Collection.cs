using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class Collection
    {

        public int Id { get; set; }
        public Address CollectionAddress { get; set; }
        public DateTime CollectionDate { get; set; }

        public string NameOfCollector { get; set; }
        public string ContactNumber { get; set; }

    }
}
