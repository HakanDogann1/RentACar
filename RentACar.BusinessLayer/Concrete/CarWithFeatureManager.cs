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
    public class CarWithFeatureManager : ICarWithFeatureService
    {
        private readonly ICarWithFeatureDal _carWithFeatureDal;

        public CarWithFeatureManager(ICarWithFeatureDal carWithFeatureDal)
        {
            _carWithFeatureDal = carWithFeatureDal;
        }

        public void TDelete(CarWithFeature t)
        {
            _carWithFeatureDal.Delete(t);
        }

        public CarWithFeature TGetById(int id)
        {
            return _carWithFeatureDal.GetById(id);
        }

        public List<CarWithFeature> TGetList()
        {
            return _carWithFeatureDal.GetList();
        }

        public void TInsert(CarWithFeature t)
        {
            _carWithFeatureDal.Insert(t);
        }

        public void TUpdate(CarWithFeature t)
        {
            _carWithFeatureDal.Update(t);
        }
    }
}
