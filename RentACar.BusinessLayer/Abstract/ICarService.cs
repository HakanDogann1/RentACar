using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Abstract
{
    public interface ICarService:IGenericService<Car>
    {
        List<Car> TGetBrandAndTransmission();
        List<Car> TGetLAs4Car();
        List<Car> TGetCarWithBrand();
        Car TGetCarFeature(int id);
    }
}
