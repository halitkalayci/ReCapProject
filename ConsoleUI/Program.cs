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
            //CarBrandandColorTest();
            IUserService userService = new UserManager(new EfUserDal());
            ICustomerService customerService = new CustomerManager(new EfCustomerDal());
            IRentalService rentalService = new RentalManager(new EfRentalDal());
            var rental = rentalService.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021,1,12),ReturnDate=new DateTime(2021,1,15) });
            Console.WriteLine(rental.Message);
        }

        private static void CarBrandandColorTest()
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
