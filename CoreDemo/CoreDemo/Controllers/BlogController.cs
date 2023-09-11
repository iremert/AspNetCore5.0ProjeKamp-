using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm=new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var list=bm.GetBlogListByCategory();
			return View(list);
		}

		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values=bm.GetBlogByID(id);
			return View(values);	
		}
	}
}
