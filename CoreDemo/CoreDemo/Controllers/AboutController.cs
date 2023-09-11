using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var list=abm.GetList();
			return View(list);
		}

		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
