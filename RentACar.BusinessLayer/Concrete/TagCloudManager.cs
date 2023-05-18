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
	public class TagCloudManager : ITagCloudService
	{
		private readonly ITagCloudDal _tagCloudDal;

		public TagCloudManager(ITagCloudDal tagCloudDal)
		{
			_tagCloudDal = tagCloudDal;
		}

		public void TDelete(TagCloud t)
		{
			_tagCloudDal.Delete(t);
		}

		public TagCloud TGetById(int id)
		{
			return _tagCloudDal.GetById(id);
		}

		public List<TagCloud> TGetList()
		{
			return _tagCloudDal.GetList();
		}

		public void TInsert(TagCloud t)
		{
			_tagCloudDal.Insert(t);
		}

		public void TUpdate(TagCloud t)
		{
			_tagCloudDal.Update(t);
		}
	}
}
