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
	public class ReserveServiceManager : IReserveServiceService
	{
		private readonly IReserveServiceDal _reserveServiceDal;

		public ReserveServiceManager(IReserveServiceDal reserveServiceDal)
		{
			_reserveServiceDal = reserveServiceDal;
		}

		public void TDelete(ReserveService t)
		{
			_reserveServiceDal.Delete(t);
		}

		public ReserveService TGetById(int id)
		{
			return _reserveServiceDal.GetById(id);
		}

		public List<ReserveService> TGetList()
		{
			return _reserveServiceDal.GetList();
		}

		public void TInsert(ReserveService t)
		{
			_reserveServiceDal.Insert(t);
		}

		public void TUpdate(ReserveService t)
		{
			_reserveServiceDal.Update(t);
		}
	}
}
