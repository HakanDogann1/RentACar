using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TDelete(Car t)
        {
            _carDal.Delete(t);
        }

        public List<Car> TGetBrandAndTransmission()
        {
            return _carDal.GetBrandAndTransmission();
        }

        public Car TGetById(int id)
        {
            return _carDal.GetById(id);
        }

		public Car TGetCarFeature(int id)
		{
			return _carDal.GetCarFeature(id);
		}

		public List<Car> TGetCarWithBrand()
		{
			return _carDal.GetCarWithBrand();
		}

		public List<Car> TGetLAs4Car()
        {
            return _carDal.GetLAs4Car();
        }

        public List<Car> TGetList()
        {
            return _carDal.GetList();
        }

        public void TInsert(Car t)
        {
            _carDal.Insert(t);
        }

        public void TUpdate(Car t)
        {
           _carDal.Update(t);
        }

      
    }
}
