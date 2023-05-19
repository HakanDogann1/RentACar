using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
	public class BlogCommentManager : IBlogCommentService
	{
		private readonly IBlogCommentDal _blogCommentDal;

		public BlogCommentManager(IBlogCommentDal blogCommentDal)
		{
			_blogCommentDal = blogCommentDal;
		}

		public void TDelete(BlogComment t)
		{
			_blogCommentDal.Delete(t);
		}

        public List<BlogComment> TGetBlogCommentWithBlog()
        {
           return _blogCommentDal.GetBlogCommentWithBlog();
        }

        public BlogComment TGetById(int id)
		{
			return _blogCommentDal.GetById(id);
		}

		public List<BlogComment> TGetList()
		{
			return _blogCommentDal.GetList();
		}

		public void TInsert(BlogComment t)
		{
			_blogCommentDal.Insert(t);
		}

		public void TUpdate(BlogComment t)
		{
			_blogCommentDal.Update(t);
		}
	}
}
