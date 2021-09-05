using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager.Starter();
            int a = 0;
        }
    }

    class Manager
    {
        public static void Starter()
        {
            Car ford = new Car();

            int trailerLength = 1;

            ford.AddTrailer(trailerLength);
        }
    }

    class Tesla : Car
    {

    }

    class Car : Wheel
    {
        public int Weight { get; set; }
        public int Length { get; private set; }

        public void AddTrailer(int lenOTrail)
        {
            this.Length = lenOTrail;
        }
    }

    class Wheel
    {
        public int numOWheel { get; private set; }
        public void AddWheel(int wheels)
        {
            this.numOWheel += wheels;
        }
        
        public void TireBlown()
        {
            this.numOWheel -= 1;
        }

    }
}
