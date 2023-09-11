using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreDemo.Models;
namespace CoreDemo.Models
{
	public class SehirlerModelView
	{
		//public List<Sehirler> sehirlers { get; set; }
		
		public List<SelectListItem> sehirlers { get; set; }
		public Writer writers { get; set; }
	}
}
