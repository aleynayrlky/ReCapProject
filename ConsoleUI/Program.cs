using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void Test1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " +
                    car.BrandId + " " +
                    car.ColorId + " " +
                    car.DailyPrice + " " +
                    car.Description + " " +
                    car.ModelYear + " " +
                    car.CarName);
            }
            Console.WriteLine("--------------------");

            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 3;
            car1.CarName = "hıa";
            car1.DailyPrice = 56;
            car1.ModelYear = 1997;
            car1.Description = "lifkdfk";

            Car car2 = new Car();
            car2.BrandId = 2;
            car2.ColorId = 1;
            car2.CarName = "dfgdfg";
            car2.DailyPrice = 565;
            car2.ModelYear = 1990;
            car2.Description = "sfgzv";

            carManager.Add(car1);
            carManager.Add(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " +
                    car.BrandId + " " +
                    car.ColorId + " " +
                    car.DailyPrice + " " +
                    car.Description + " " +
                    car.ModelYear + " " +
                    car.CarName);
            }
            Console.WriteLine("--------------------");

            carManager.Delete(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " +
                    car.BrandId + " " +
                    car.ColorId + " " +
                    car.DailyPrice + " " +
                    car.Description + " " +
                    car.ModelYear + " " +
                    car.CarName);
            }
            Console.WriteLine("--------------------");

            carManager.Update(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " +
                    car.BrandId + " " +
                    car.ColorId + " " +
                    car.DailyPrice + " " +
                    car.Description + " " +
                    car.ModelYear + " " +
                    car.CarName);
            }
            Console.WriteLine("--------------------");
        }
    }
}
