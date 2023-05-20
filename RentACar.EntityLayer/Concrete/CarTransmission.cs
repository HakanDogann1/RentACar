using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class CarTransmission
    {
        public int CarTransmissionID { get; set; }
        public string CarTransmissionName { get; set; }
        List<Car> Cars { get; set; }
    }
}
