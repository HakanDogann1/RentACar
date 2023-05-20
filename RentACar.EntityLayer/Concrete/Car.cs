using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; set; }
        public int CarBrandID { get; set; }
        public CarBrand CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarMillage { get; set; }
        public int CarTransmissionID { get; set; }
        public CarTransmission CarTransmission { get; set; }
        public int CarSeats { get; set; }
        public int CarLuggage { get; set; }
        public string CarFuel { get; set; }
        public double CarPrice { get; set; }
        public string CarImageUrl { get; set; }
        List<CarWithFeature> CarWithFeatures { get; set; }
        List<CarRegister> CarRegisters { get; set; }
    }
}
