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
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        public List<Car> GetBrandAndTransmission()
        {
            Context context = new Context();
            return context.Cars.Include(x=>x.CarBrand).Include(y=>y.CarTransmission).ToList();
        }

        public List<Car> GetLAs4Car()
        {
            Context context= new Context();
            return context.Cars.OrderByDescending(x=>x.CarID).Take(4).ToList();
        }
    }
}
