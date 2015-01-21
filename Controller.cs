using System;
using CarLibrary;

namespace CarApplication
{
    class Controller
    {
        Car myNewCar;

        public Controller()
        {
            myNewCar = new Car("Flash", 160, 15);
        }

        public void SowCarState()
        {
            Console.WriteLine("Car \"{0}\", CurrSpeed {1}, Acceleration {2}, Engine is {3}.",
                myNewCar.CarName, myNewCar.CurrSpeed, myNewCar.Acceleration, myNewCar.IsEngineOn?"on":"off");
        }

        public void StartStopEngine()
        {
            myNewCar.IsEngineOn = !myNewCar.IsEngineOn;
        }

        public void Fastly()
        {
            myNewCar.SpeedUp();
        }
        public void Slowly()
        {
            myNewCar.SpeedDown();
        }

    }
}
