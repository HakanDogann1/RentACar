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
	public class BlogManager : IBlogService
	{
		private readonly IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void TDelete(Blog t)
		{
			_blogDal.Delete(t);
		}

		public Blog TGetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> TGetList()
		{
			return _blogDal.GetList();
		}

		public void TInsert(Blog t)
		{
			_blogDal.Insert(t);
		}

		public void TUpdate(Blog t)
		{
			_blogDal.Update(t);
		}
	}
}
