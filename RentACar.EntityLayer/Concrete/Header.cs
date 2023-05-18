using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class Header
	{
        public int HeaderID { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderDescription { get; set; }
        public string HeaderImageUrl { get; set; }
        public string HeaderVideo { get; set; }
    }
}
