using System;
using System.Linq.Expressions;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.InMemoryDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                 new Car{ColorId=1, BrandId=1, DailyPrice=2000, CarId=1, Description="Günlük kiralık.", ModelYear=2005},
                 new Car{ColorId=1, BrandId=2, DailyPrice=3500, CarId=2, Description="Günlük kiralık.", ModelYear=2012},
                 new Car{ColorId=3, BrandId=4, DailyPrice=4500, CarId=3, Description="Günlük kiralık.", ModelYear=2020},
                 new Car{ColorId=2, BrandId=5, DailyPrice=1000, CarId=4, Description="Günlük kiralık.", ModelYear=1998}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.Single(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.Single(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

