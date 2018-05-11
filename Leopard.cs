using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Lab
{
    class Leopard : Pantherinae
    {
        public Leopard(double growth, double weight, double speed, string breed) : base(growth, weight, speed, breed) { }

        public override void Description()
        {
            Console.WriteLine("\nParameters of {0} are:\n" +
                "average growth at the withers - {1} centimeters \n" +
                "average weight for male - {2} kilo \n" +
                "average speed in short bursts - {3} km/h ", breed, growth, weight, speed);
        }

    }
}