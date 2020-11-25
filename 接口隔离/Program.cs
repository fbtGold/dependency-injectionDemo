using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口隔离
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new HeavyTank());
            driver.work();
        }


    }

    class Driver
    {
        public ITank _vehicle;

        public Driver(ITank vehicle)
        {
            _vehicle = vehicle;
        }

        public void work()
        {
            _vehicle.Run();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    class Car:IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is runing!");
        }
    }

    class Truck:IVehicle
    {
       public void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }

    interface ITank
    {
        void Run();

        void Fire();
    }

    class HeavyTank:ITank
    {
        public void Run()
        {
            Console.WriteLine("Tank is running");
        }

        public void Fire()
        {
            Console.WriteLine("Boom!");
        }
    }
}
