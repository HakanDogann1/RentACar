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
    public class CarRegisterManager : ICarRegisterService
    {
        private readonly ICarRegisterDal _carRegisterDal;

        public CarRegisterManager(ICarRegisterDal carRegisterDal)
        {
            _carRegisterDal = carRegisterDal;
        }

        public void TDelete(CarRegister t)
        {
            _carRegisterDal.Delete(t);
        }

        public CarRegister TGetById(int id)
        {
           return _carRegisterDal.GetById(id);
        }

        public List<CarRegister> TGetCarRegisterWithCarByUser(int id)
        {
            return _carRegisterDal.GetCarRegisterWithCarByUser(id);
        }

        public List<CarRegister> TGetList()
        {
            return _carRegisterDal.GetList();
        }

        public void TInsert(CarRegister t)
        {
            _carRegisterDal.Insert(t);
        }

        public void TUpdate(CarRegister t)
        {
            _carRegisterDal.Update(t);
        }
    }
}
