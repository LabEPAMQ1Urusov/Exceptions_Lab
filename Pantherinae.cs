using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Lab
{
    abstract class Pantherinae
    {
        public double growth;
        public double weight;
        public double speed;
        public string breed;

        public Pantherinae(double growth, double weight, double speed, string breed)
        {
            this.growth = growth;
            this.weight = weight;
            this.speed = speed;
            this.breed = breed;
        }

        public abstract void Description();
    }
}
