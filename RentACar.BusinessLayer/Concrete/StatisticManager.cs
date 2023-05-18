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
	public class StatisticManager : IStatisticService
	{
		private readonly IStatisticDal _statisticDal;

		public StatisticManager(IStatisticDal statisticDal)
		{
			_statisticDal = statisticDal;
		}

		public void TDelete(Statistic t)
		{
			_statisticDal.Delete(t);
		}

		public Statistic TGetById(int id)
		{
			return _statisticDal.GetById(id);
		}

		public List<Statistic> TGetList()
		{
			return _statisticDal.GetList();
		}

		public void TInsert(Statistic t)
		{
			_statisticDal.Insert(t);
		}

		public void TUpdate(Statistic t)
		{
			_statisticDal.Update(t);
		}
	}
}
