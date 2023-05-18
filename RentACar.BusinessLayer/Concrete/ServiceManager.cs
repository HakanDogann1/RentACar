﻿using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TDelete(Service t)
		{
			_serviceDal.Delete(t);
		}

		public Service TGetById(int id)
		{
			return _serviceDal.GetById(id);
		}

		public List<Service> TGetList()
		{
			return _serviceDal.GetList();
		}

		public void TInsert(Service t)
		{
			_serviceDal.Insert(t);
		}

		public void TUpdate(Service t)
		{
			_serviceDal.Update(t);
		}
	}
}
