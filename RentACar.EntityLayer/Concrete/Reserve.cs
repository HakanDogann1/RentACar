using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class Reserve
	{
        public int ReserveID { get; set; }
        public string PıckUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public DateTime PıckUpDate { get; set; }
        public DateTime DropOfDate { get; set; }
        public DateTime PickUpTime { get; set; }
    }
}
