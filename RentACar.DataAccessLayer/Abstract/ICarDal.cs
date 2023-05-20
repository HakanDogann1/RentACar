using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.Abstract
{
    public interface ICarDal:IGenericDal<Car>
    {
        List<Car> GetBrandAndTransmission();
        List<Car> GetLAs4Car();

    }
}
