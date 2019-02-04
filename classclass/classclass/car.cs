using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classclass
{
    class car
    {
        //properties
        public string make;
        public string model;
        public double mileage;
        public double tankSize;
        public double gasInGallons;
        public double milesPerGallon;
        //constructor
        public car ()
        {
            make = "Ford";
            model = "Escape";
            mileage = 0;
            tankSize = 13;
            gasInGallons = tankSize;
            milesPerGallon = 24;
        }
        public car (String Make, string Model, double TankSize, double mpg)
        {
            make = Make;
            model = Model;
            tankSize = TankSize;
            mileage = 0;
            gasInGallons = TankSize;
        }
        //methoods
        public void DriveTilEmpty()
        {
            mileage = mileage + milesPerGallon * gasInGallons;
            gasInGallons = 0; 
        }
    }
}
