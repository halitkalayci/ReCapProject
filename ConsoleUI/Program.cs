using Business.Abstract;
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
            ICarService carService = new CarManager(new EfCarDal());

            carService.Add(new Car { ModelYear = 2012, Description = "BMW M5", DailyPrice = 120, BrandId = 1 ,ColorId = 1 });

            foreach (Car car in carService.GetAll())
            {
                Console.WriteLine($"\n {car.Id} kodlu araba bilgileri : {car.Description} , Günlük ücret {car.DailyPrice} , Model Yılı {car.ModelYear} \n");
            }
        }
    }
}
