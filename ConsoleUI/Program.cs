using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + 
                    car.BrandId + " " + 
                    car.ColorId + " " + 
                    car.DailyPrice + " " + 
                    car.Description + " " + 
                    car.ModelYear);
            }
            Console.WriteLine("--------------------");

            Car car1 = new Car()
            {
                CarId = 6,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 150,
                ModelYear = 2013,
                Description = "Hyundai"
            };
            Car car2 = new Car()
            {
                CarId = 7,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 300,
                ModelYear = 2018,
                Description = "Bmw"
            };
            carManager.Add(car1);
            carManager.Add(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " +
                    car.BrandId + " " +
                    car.ColorId + " " +
                    car.DailyPrice + " " +
                    car.Description + " " +
                    car.ModelYear);
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
                    car.ModelYear);
            }
            Console.WriteLine("--------------------");

            //carManager.Update(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " +
            //        car.BrandId + " " +
            //        car.ColorId + " " +
            //        car.DailyPrice + " " +
            //        car.Description + " " +
            //        car.ModelYear);
            //}
            //Console.WriteLine("--------------------");

            //carManager.GetByColorId(2);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " +
            //        car.BrandId + " " +
            //        car.ColorId + " " +
            //        car.DailyPrice + " " +
            //        car.Description + " " +
            //        car.ModelYear);
            //}
            //Console.WriteLine("--------------------");
        }
    }
}
