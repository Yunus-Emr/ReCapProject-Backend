using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }


        public IResult Add(CarImage image)
        {
            _imageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(CarImage image)
        {
            _imageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll());
        }

        public IResult Update(CarImage image)
        {
            _imageDal.Update(image);
            return new SuccessResult();
        }
        private IResult CheckIfImage
    }
}
