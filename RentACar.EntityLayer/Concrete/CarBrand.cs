using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class CarBrand
    {
        public int CarBrandID { get; set; }
        public string CarBrandName { get; set; }
        List<Car> Cars { get; set; }
    }
}
