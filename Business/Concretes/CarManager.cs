using System;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
	public class CarManager:ICarService
	{
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                Console.WriteLine("Günlük fiyat 0'dan büyük olmalıdır.");
            }
            if (car.CarName.Length<3)
            {
                Console.WriteLine("Araba ismi minimum 2 karakterden oluşmalıdır.");
            }
            _carDal.Add(car);
        }
        
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.Get(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.Get(c => c.ColorId == id);
        }
    }
}
 
