using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class Cars
    {

        public Cars()
        {

        }

        public Cars(string platenumber, string color, double kilometers)
        {
            PlateNumber = platenumber;
            Color = color;
            Kilometers = kilometers;
        }

        public string PlateNumber { get; set; }

        public string Color { get; set; }

        public double Kilometers { get; set; }

        public void AddKilometers (double km )
            {
            Kilometers += km;
            }

        public void ResetKilometers(double km)
        {
            Kilometers = 0;
        }

    }
}
