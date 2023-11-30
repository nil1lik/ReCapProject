using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICarService
	{
		List<Car> GetCarsByBrandId(int id);
		List<Car> GetCarsByColorId(int id);
		void Add(Car car);
	}
}

