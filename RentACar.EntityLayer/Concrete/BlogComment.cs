using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
	public class BlogComment
	{
        public int BlogCommentID { get; set; }
        public string BlogCommentName { get; set; }
        public string BlogCommentSurname { get; set; }
        public string BlogCommentEMail { get; set; }
        public string BlogCommentMessage { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
