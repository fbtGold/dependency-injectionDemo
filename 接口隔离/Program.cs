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
            var driver = new Driver(new Car());
            driver.work();
        }


    }

    class Driver
    {
        public IVehicle _vehicle;

        public Driver(IVehicle vehicle)
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

    interface IWeapon
    {
        void Fire();
    }

    

    interface ITank:IWeapon,IVehicle
    {
        
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
