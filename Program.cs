using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // intializing
            Plane testPlane = new Plane();
            Plane plane1 = new Plane("MO26", PlaneType.Jet, 8, 10);

            plane1.AddASeat();
            plane1.AddASeat();
            plane1.ShowInfo();
        }
    }
}
