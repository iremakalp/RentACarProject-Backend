using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // IlkDeneme();
            // CarDetails();
            // CarAdded();
            // GetAllMessages();
            // CarDelete();
            // CarUpdate();
            // ColorAdd();
            // BrandAdd();
            // RentalAdd();

        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                Name = "Peugeot"
            });
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                Name = "Pembe"
            });
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                Id = 1,
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2020, 01, 21),
                ReturnDate = new DateTime(2020, 6, 29)
            });
            Console.WriteLine(result.Message);
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Update(new Car { Id = 1, ColorId = 2 });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result=carManager.Delete(new Car { Id = 3 });
            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void GetAllMessages()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car
            {
                BrandId = 2,
                ColorId = 4,
                Description = "Renault Marka 2021 Model",
                DailyPrice = 136000,
                ModelYear = 2021
            };
            var result = carManager.Add(car1);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + " / " + car.CarName + " / " + car.BrandName + " / " +
                    car.ColorName + " / " + car.DailyPrice);
            }
        }

        private static void IlkDeneme()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("---------- Arabalar -------------");
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("\n-------- Markaya Göre Seçilen Araçlar ------- \n");
            foreach (var item in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("\n-------- Seçilen Renge Göre Araçlar ------- \n");
            foreach (var item in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(item.Description);
            }
            // yeni arac ekleme
            Car car1 = new Car
            {
                BrandId = 2,
                ColorId = 4,
                Description = "Renault Marka 2021 Model",
                DailyPrice = 136000,
                ModelYear = 2021
            };
            Car car2 = new Car
            {
                BrandId = 3,
                ColorId = 4,
                Description = "BMW Marka 2021 Model",
                DailyPrice = 336000,
                ModelYear = 2021
            };
            carManager.Add(car1);
            carManager.Add(car2);
            Console.WriteLine("---------- Arabalar -------------");
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
