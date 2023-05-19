using Microsoft.EntityFrameworkCore;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.EntityFramework
{
    public class EfBlogCommentDal : GenericRepository<BlogComment>, IBlogCommentDal
    {
        public List<BlogComment> GetBlogCommentWithBlog()
        {
            using var context=new Context();
            return context.BlogComments.Include(x=>x.Blog).ToList();
        }
    }
}
