using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1,ColorId=2,BrandId=2, ModelYear = 2023,DailyPrice = 400,CarName = "Yeni model",},
                new Car{CarId = 1,ColorId=2,BrandId=2, ModelYear = 2015,DailyPrice = 5247,CarName = "Güzel araba "},
                new Car{CarId = 1,ColorId=3,BrandId=4, ModelYear = 2022, DailyPrice = 1000, CarName = "Sıfır araba"},
                new Car{CarId = 1,ColorId=3,BrandId=4, ModelYear = 2009, DailyPrice = 1500, CarName = "sadece ve sadece 3 takla attı"},
                new Car{CarId = 1,ColorId=3,BrandId=4, ModelYear = 2012,DailyPrice = 850, CarName = "takas düşünülür"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int byId)
        {
            return _car.Where(c => c.BrandId == byId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.CarName =car.CarName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
