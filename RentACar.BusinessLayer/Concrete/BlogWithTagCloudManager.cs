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
	public class BlogWithTagCloudManager : IBlogWithTagCloudService
	{
		private readonly IBlogWithTagCloudDal _blogWithTagCloudDal;

		public BlogWithTagCloudManager(IBlogWithTagCloudDal blogWithTagCloudDal)
		{
			_blogWithTagCloudDal = blogWithTagCloudDal;
		}

		public void TDelete(BlogWithTagCloud t)
		{
			_blogWithTagCloudDal.Delete(t);
		}

		public BlogWithTagCloud TGetById(int id)
		{
			return _blogWithTagCloudDal.GetById(id);
		}

		public List<BlogWithTagCloud> TGetList()
		{
			return _blogWithTagCloudDal.GetList();
		}

		public void TInsert(BlogWithTagCloud t)
		{
			_blogWithTagCloudDal.Insert(t);
		}

		public void TUpdate(BlogWithTagCloud t)
		{
			_blogWithTagCloudDal.Update(t);
		}
	}
}
