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
    public class CarTransmissionManager : ICarTransmissionService
    {
        private readonly ICarTransmissionDal _carTransmissionDal;

        public CarTransmissionManager(ICarTransmissionDal carTransmissionDal)
        {
            _carTransmissionDal = carTransmissionDal;
        }

        public void TDelete(CarTransmission t)
        {
            _carTransmissionDal.Delete(t);
        }

        public CarTransmission TGetById(int id)
        {
            return _carTransmissionDal.GetById(id);
        }

        public List<CarTransmission> TGetList()
        {
            return _carTransmissionDal.GetList();
        }

        public void TInsert(CarTransmission t)
        {
           _carTransmissionDal.Insert(t);
        }

        public void TUpdate(CarTransmission t)
        {
            _carTransmissionDal.Update(t);
        }
    }
}
