using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect(duration:100)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        [CacheAspect(duration: 100)]
        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailsDto>>(result);
        }
        [CacheAspect(duration: 100)]
        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            var result = _carDal.GetAll(c => c.BrandId == id);
            return new SuccessDataResult<List<Car>>(result);
        }
        [CacheAspect(duration: 100)]
        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            var result = _carDal.GetAll(c => c.ColorId == id);
            return new SuccessDataResult<List<Car>>(result);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
