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
	public class HeaderManager : IHeaderService
	{
		private readonly IHeaderDal _headerService;

		public HeaderManager(IHeaderDal headerService)
		{
			_headerService = headerService;
		}

		public void TDelete(Header t)
		{
			_headerService.Delete(t);
		}

		public Header TGetById(int id)
		{
			return _headerService.GetById(id);
		}

		public List<Header> TGetList()
		{
			return _headerService.GetList();
		}

		public void TInsert(Header t)
		{
			_headerService.Insert(t);
		}

		public void TUpdate(Header t)
		{
			_headerService.Update(t);
		}
	}
}
