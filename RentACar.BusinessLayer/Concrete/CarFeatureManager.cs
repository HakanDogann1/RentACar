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
    public class CarFeatureManager : ICarFeatureService
    {
        private readonly ICarFeatureDal _carFeatureDal;

        public CarFeatureManager(ICarFeatureDal carFeatureDal)
        {
            _carFeatureDal = carFeatureDal;
        }

        public void TDelete(CarFeature t)
        {
            _carFeatureDal.Delete(t);
        }

        public CarFeature TGetById(int id)
        {
            return _carFeatureDal.GetById(id);
        }

        public List<CarFeature> TGetList()
        {
            return _carFeatureDal.GetList();
        }

        public void TInsert(CarFeature t)
        {
             _carFeatureDal.Insert(t);
        }

        public void TUpdate(CarFeature t)
        {
            _carFeatureDal.Update(t);
        }
    }
}
