using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IResult Add(CarImage image);
        public IResult Delete(CarImage image);
        public IResult Update(CarImage image);
        public IDataResult<List<CarImage>> GetAll();
    }
}
