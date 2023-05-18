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
	public class ContactMeManager : IContactMeService
	{
		private readonly IContactMeDal _contactMeDal;

		public ContactMeManager(IContactMeDal contactMeDal)
		{
			_contactMeDal = contactMeDal;
		}

		public void TDelete(ContactMe t)
		{
			_contactMeDal.Delete(t);
		}

		public ContactMe TGetById(int id)
		{
			return _contactMeDal.GetById(id);
		}

		public List<ContactMe> TGetList()
		{
			return _contactMeDal.GetList();

		}

		public void TInsert(ContactMe t)
		{
			_contactMeDal.Insert(t);
		}

		public void TUpdate(ContactMe t)
		{
			_contactMeDal.Update(t);
		}
	}
}
