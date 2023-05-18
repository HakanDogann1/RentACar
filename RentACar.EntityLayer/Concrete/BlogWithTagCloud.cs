using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class BlogWithTagCloud
	{
        public int BlogWithTagCloudID { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        public int TagCloudID { get; set; }
        public TagCloud TagCloud { get; set; }
    }
}
