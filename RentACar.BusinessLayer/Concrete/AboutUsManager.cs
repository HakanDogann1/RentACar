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
	public class AboutUsManager : IAboutUsService
	{
		private readonly IAboutUsDal _aboutUsDal;

		public AboutUsManager(IAboutUsDal aboutUsDal)
		{
			_aboutUsDal = aboutUsDal;
		}

		public void TDelete(AboutUs t)
		{
			_aboutUsDal.Delete(t);
		}

		public AboutUs TGetById(int id)
		{
			return _aboutUsDal.GetById(id);
		}

		public List<AboutUs> TGetList()
		{
			return _aboutUsDal.GetList();
		}

		public void TInsert(AboutUs t)
		{
			_aboutUsDal.Insert(t);
		}

		public void TUpdate(AboutUs t)
		{
			_aboutUsDal.Update(t);
		}
	}
}
