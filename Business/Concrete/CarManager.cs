using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Araba eklenemedi. Açıklama 2 karakterden uzun olmalıdır.");
                return;
            }
            if(car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba eklenemedi. Günlük fiyat 0'dan büyük olmalıdır.");
                return;
            }
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetAllDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(c=> c.BrandId==brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(c=> c.ColorId == colorId);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c=>c.Id == carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
