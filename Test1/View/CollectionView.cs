
using Test1.Models;

namespace Test1.View
{
    public class CollectionView
    {

        public Collection CollectionCapture()
        {
            Collection collection = new Collection();

            Console.WriteLine("------------------Collection-----------------------------");

            Console.WriteLine("Enter Collection address (This is the desired address from which the parcel will be\r\ncollected) : ");

            var address = new Address();

            Console.WriteLine("Enter Street name : ");
            address.Street = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter Postal Code : ");
            address.PostalCode = Console.ReadLine();

            collection.CollectionAddress = address;


            Console.WriteLine("Enter Date of collection (YYYY/MM/DD) : ");
            collection.CollectionDate = DateTime.Parse(Console.ReadLine());  // this is going to scream if the format is in correct

            Console.WriteLine("Enter the name of the collector  : ");
            collection.NameOfCollector = Console.ReadLine();

            Console.WriteLine("Enter their contact number : ");
            collection.ContactNumber = Console.ReadLine();

            Console.WriteLine("------------------Collection-----------------------------");

            return collection;
        }
    }
}
