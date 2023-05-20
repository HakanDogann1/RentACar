using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class CarWithFeature
    {
        public int CarWithFeatureID { get; set; }
        public int CarFeatureID { get; set; }
        public CarFeature CarFeature { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }

    }
}
