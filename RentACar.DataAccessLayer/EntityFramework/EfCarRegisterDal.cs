using Microsoft.EntityFrameworkCore;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.EntityFramework
{
    public class EfCarRegisterDal : GenericRepository<CarRegister>, ICarRegisterDal
    {
        public List<CarRegister> GetCarRegisterWithCarByUser(int id)
        {
            Context context = new Context();
            var values = context.CarRegisters.Where(x=>x.AppUserID == id).Include(y=>y.Car).Include(z=>z.Car.CarBrand).Include(t => t.Car.CarTransmission).ToList();
            return values;
        }
    }
}
