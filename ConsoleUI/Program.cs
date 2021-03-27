using Business.Abstract;
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
            ICarService carService = new CarManager(new InMemoryCarDal());

            carService.Add(new Car { Id = 1001, BrandId = 1, ColorId = 2, DailyPrice = 500, Description = "Peugeout Partner", ModelYear = 2016 });
            carService.Add(new Car { Id = 1002, BrandId = 4, ColorId = 2, DailyPrice = 120, Description = "Opel Corsa", ModelYear = 2020 });
            carService.Delete(new Car { Id = 1001 });
            carService.Update(new Car { Id = 1002, BrandId = 4, ColorId = 2, DailyPrice = 140, Description = "Opel Corsa", ModelYear = 2020 });

            foreach (Car car in carService.GetAll())
            {
                Console.WriteLine($"\n {car.Id} kodlu araba bilgileri : {car.Description} , Günlük ücret {car.DailyPrice} , Model Yılı {car.ModelYear} \n");
            }
        }
    }
}
