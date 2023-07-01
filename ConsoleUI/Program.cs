using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Result;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //BrandTest();

            //IdTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)           
                Console.WriteLine(color.ColorName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if(result.Success)
            foreach (var brand in result.Data)
                Console.WriteLine(brand.BrandId);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var car in    result.Data)           
                Console.WriteLine(car.CarName);           
        }
        private static void IdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(2);
            Console.WriteLine(result.Data);
        }
    }
}