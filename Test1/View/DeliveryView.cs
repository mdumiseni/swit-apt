using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test1.Models;

namespace Test1.View
{
    public class DeliveryView
    {
        public Delivery CaptureDelivery()
        {
            Delivery delivery = new Delivery();

            Console.WriteLine("------------------Delivery-----------------------------");

            Console.WriteLine("Enter Delivery address (This is the desired address from which the parcel will be Delivered) : ");

            var address = new Address();

            Console.WriteLine("Enter Street name : ");
            address.Street = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter Postal Code : ");
            address.PostalCode = Console.ReadLine();

            delivery.DeliveryAddress = address;


            Console.WriteLine("Enter Date of collection (YYYY/MM/DD) : ");
            delivery.DeliveryDate = DateTime.Parse(Console.ReadLine());  // this is going to scream if the format is in correct

            Console.WriteLine("Enter the name of the deliver  : ");
            delivery.DeliveryContactName = Console.ReadLine();

            Console.WriteLine("Enter their contact number : ");
            delivery.ContactNumber= Console.ReadLine();

            Console.WriteLine("------------------Delivery-----------------------------");

            return delivery;
            
        }
    }
}
