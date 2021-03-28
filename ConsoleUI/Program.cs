using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            IBrandService brandService = new BrandManager(new EfBrandDal());
            IColorService colorService = new ColorManager(new EfColorDal());

            foreach (Car car in carService.GetAll().Data)
            {
                Console.WriteLine($"\n {car.Id} kodlu araba bilgileri : {car.Description} , Günlük ücret {car.DailyPrice} , Model Yılı {car.ModelYear} \n");
            }
            foreach (CarDetailDto carDetail in carService.GetAllDetails().Data)
            {
                Console.WriteLine($"{carDetail.Id} - {carDetail.BrandName} - {carDetail.CarName} - {carDetail.ColorName} - {carDetail.DailyPrice}");
            }
            foreach (Color color in colorService.GetAll().Data)
            {
                Console.WriteLine($"{color.Id} kodlu renk : {color.Name}");
            }
            foreach (Brand brand in brandService.GetAll().Data)
            {
                Console.WriteLine($"{brand.Id} kodlu marka : {brand.Name}");
            }

        }
    }
}
