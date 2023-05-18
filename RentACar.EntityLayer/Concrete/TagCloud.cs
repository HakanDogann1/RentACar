using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class TagCloud
	{
        public int TagCloudID { get; set; }
        public string TagCloudTitle { get; set; }
        List<BlogWithTagCloud> BlogWithTagClouds { get; set; }
    }
}
