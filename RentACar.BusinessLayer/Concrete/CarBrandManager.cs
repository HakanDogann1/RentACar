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
    public class CarBrandManager : ICarBrandService
    {
        private readonly ICarBrandDal _carBrandDal;

        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }

        public void TDelete(CarBrand t)
        {
            _carBrandDal.Delete(t);
        }

        public CarBrand TGetById(int id)
        {
            return _carBrandDal.GetById(id);
        }

        public List<CarBrand> TGetList()
        {
            return _carBrandDal.GetList();
        }

        public void TInsert(CarBrand t)
        {
            _carBrandDal.Insert(t);
        }

        public void TUpdate(CarBrand t)
        {
            _carBrandDal.Update(t);
        }
    }
}
