using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        //The user must be able to input the weight (displayed in kilograms) and dimensions
        //(Length, width and height - displayed in centimeters) of the parcel within the program.

        public decimal weight { get; set; }
        public decimal Length { get; set; }
        public decimal width { get; set; }

        public decimal height  { get; set; }

        public decimal VolumetricMass { get; }

        public string SpecialInstructions { get; set; }

        public EServiceSummary eServiceSummary { get; set; }

        public decimal GetVolumetricMass()
        {
            return (weight* Length * height)/4000;
        }
    }
}
