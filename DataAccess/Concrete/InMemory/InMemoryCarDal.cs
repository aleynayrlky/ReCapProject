using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=250, Description="opel"},
                new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=1998, DailyPrice=50, Description="bmw"},
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear=2003, DailyPrice=100, Description="tofaş"},
                new Car{CarId=4, BrandId=2, ColorId=1, ModelYear=2010, DailyPrice=200, Description="jeep"},
                new Car{CarId=5, BrandId=2, ColorId=1, ModelYear=2005, DailyPrice=150, Description="hunda"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
