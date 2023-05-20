using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public string CarFeatureName { get; set; }

        List<CarWithFeature> CarWithFeatures { get; set; }
    }
}
