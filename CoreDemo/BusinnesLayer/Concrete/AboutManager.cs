using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _ıaboutdal;

		public AboutManager(IAboutDal ıaboutdal)
		{
			_ıaboutdal = ıaboutdal;
		}

		public List<About> GetList()
		{
			return _ıaboutdal.GetListAll();
		}
	}
}
