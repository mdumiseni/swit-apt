using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test1.Models;

namespace Test1.View
{
    public class CheckOutSummartView
    {
        private readonly CheckoutSummary _checkoutSummary;
        public CheckOutSummartView(CheckoutSummary checkoutSummary)
        {
           _checkoutSummary = checkoutSummary;
        }

        public void CheckoutSummary()
        {
            Console.WriteLine("------------------Check out Summary--------------------");



            Console.WriteLine("------------------Collection Information--------------------");
            Console.WriteLine($"Collection adddress {_checkoutSummary.CollectionInformation.CollectionAddress.Street} , {_checkoutSummary.CollectionInformation.CollectionAddress.City}, {_checkoutSummary.CollectionInformation.CollectionAddress.PostalCode}");
            Console.WriteLine("------------------Collection Information--------------------");


            Console.WriteLine("------------------Delivery Information--------------------");
            Console.WriteLine($"Delivery adddress {_checkoutSummary.DeliveryInformation.DeliveryAddress.Street} , {_checkoutSummary.DeliveryInformation.DeliveryAddress.City}, {_checkoutSummary.DeliveryInformation.DeliveryAddress.PostalCode}");
            Console.WriteLine("------------------Delivery Information--------------------");

            Console.WriteLine("------------------Parcel Information--------------------");
            Console.WriteLine($" Length {_checkoutSummary.ParcelInformation.Length} , width {_checkoutSummary.ParcelInformation.width}, heigh{_checkoutSummary.ParcelInformation.height}," +
                $" Volumetric mass{_checkoutSummary.ParcelInformation.GetVolumetricMass()}");

            switch (_checkoutSummary.ParcelInformation.eServiceSummary)
            {
                case EServiceSummary.SameDayDelivery:
                    Console.WriteLine("Same Day Delivery");
                    break;
                case EServiceSummary.Overnight:
                    Console.WriteLine("Overnight");
                    break;
                case EServiceSummary.Economy:
                    Console.WriteLine("Economy");
                    break;
                default:
                    break;
            }

            Console.WriteLine();




            Console.WriteLine("------------------Parcel Information--------------------");
            Console.WriteLine("------------------Check out Summary--------------------");
        }
    }
}
