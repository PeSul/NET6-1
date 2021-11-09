using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Cars
    {
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
