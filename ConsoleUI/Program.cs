using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.CarName);
            //}
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId=12,ModelYear = 2022, CarName = "Civic", DailyPrice = 19750,BrandId=2,ColorId=2});
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("CarId={0},ModelYear={1},CarName={2},DailyPrice={3},BrandId{4},ColorId={5}",cars.CarId,cars.ModelYear,cars.CarName,cars.DailyPrice,cars.BrandId,cars.ColorId);
            }
        }
    }
}