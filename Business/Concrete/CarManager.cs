using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                _CarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Ekleme başarısız ");
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p=>p.ColorId==id);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}
