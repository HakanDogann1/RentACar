using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class Blog
	{
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContentTitle1 { get; set; }
        public string BlogContentTitle2 { get; set; }
        public string BlogDescription { get; set; }
        public string BlogContentDescription1 { get; set; }
        public string BlogContentDescription2 { get; set; }
        public string BlogImageUrl { get; set; }
        public DateTime BlogDate { get; set; }

        List<BlogWithTagCloud> BlogWithTagClouds { get; set; }

        List<BlogComment> BlogComments { get; set; }
       
    }
}
