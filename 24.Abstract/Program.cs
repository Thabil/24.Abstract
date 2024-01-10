using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car1 = new Vehicle(); //this is not possible as parent class is abstract! to increase security
            Corsa car2 = new Corsa();
            Console.WriteLine(car2.wheels);

            Console.ReadLine();
        }
    }

    abstract class Vehicle
    {

        public int wheels = 4;
    }

    class Corsa : Vehicle
    { 
        public int sparewheels = 1;
    }
    
}
