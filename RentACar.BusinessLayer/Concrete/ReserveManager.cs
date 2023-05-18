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
	public class ReserveManager : IReserveService
	{
		private readonly IReserveDal _reserveDal;

		public ReserveManager(IReserveDal reserveDal)
		{
			_reserveDal = reserveDal;
		}

		public void TDelete(Reserve t)
		{
			_reserveDal.Delete(t);
		}

		public Reserve TGetById(int id)
		{
			return _reserveDal.GetById(id);
		}

		public List<Reserve> TGetList()
		{
			return _reserveDal.GetList();
		}

		public void TInsert(Reserve t)
		{
			_reserveDal.Insert(t);
		}

		public void TUpdate(Reserve t)
		{
			_reserveDal.Update(t);
		}
	}
}
