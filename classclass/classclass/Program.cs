using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classclass
{
    class Program
    {
        static void Main(string[] args)
        {
            car BakerCar = new car();
            Console.WriteLine("Bakers car =" + BakerCar.model);
            car PeteCar = new car(Make: "Ford", Model: "Mustang", TankSize: 14, mpg: 13);

            BakerCar.DriveTilEmpty();
        }
    }
}
