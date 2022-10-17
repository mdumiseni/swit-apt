using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test1.Models;

namespace Test1.View
{
    public class ParcelView
    {
        public Parcel CaptureParcelInformation()
        {
            Parcel parcel = new Parcel();

            Console.WriteLine("------------------Parcel Information-----------------------------");

            //(Length, width and height - displayed in centimeters) of
            Console.WriteLine("Enter Length (cm) : ");
            parcel.Length = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter width (cm): ");
            parcel.weight = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter height (cm): ");
            parcel.height = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Add notes : ");
            parcel.SpecialInstructions = Console.ReadLine();

            Console.WriteLine("Please select service by entering the service number  : ");

            Console.WriteLine("1.Same - Day Delivery: R500 : ");
            Console.WriteLine("2. Overnight: R250  : ");
            Console.WriteLine("3. Economy: R125  : ");

            int serviceSumaary  = int.Parse(Console.ReadLine());

            parcel.eServiceSummary = (EServiceSummary)serviceSumaary;

            Console.WriteLine("Volumetric mass is : "+ parcel.GetVolumetricMass());
            Console.WriteLine("------------------Parcel Information-----------------------------");
            Console.ReadLine();
            return parcel;
        }
    }
}
