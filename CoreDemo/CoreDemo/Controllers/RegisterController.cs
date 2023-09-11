using BusinnesLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreDemo.Models;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BusinnesLayer.ValidationRules;
using FluentValidation.Results; //bunu eklmeye özen göster çünkü bende otomatikl ekleyici var bunu eklemiyor !!!
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());



		[HttpGet]
		public IActionResult Index()
		{

			//List<Sehirler> sehirlistesi = new List<Sehirler>();         //böylede oldu ama listeleme kısmı olsada bazı sıkıntılar oluyor ondan tamamen çözcem :)

			//Sehirler sehir = new Sehirler();
			//sehir.ID = 1;
			//sehir.name = "Kocaeli";
			//sehirlistesi.Insert(0, sehir);

			//Sehirler sehir2 = new Sehirler();
			//sehir2.ID = 2;
			//sehir2.name = "Samsun";
			//sehirlistesi.Insert(1, sehir2);

			//Sehirler sehir3 = new Sehirler();
			//sehir3.ID = 3;
			//sehir3.name = "Ankara";
			//sehirlistesi.Insert(2, sehir3);

			//SehirlerModelView smv = new SehirlerModelView();
			//smv.sehirlers = sehirlistesi;
			//List<SelectListItem> sehirlistesii = (from x in smv.sehirlers
			//									  select new SelectListItem
			//									  {
			//										  Text = x.name,
			//										  Value = x.ID.ToString()
			//									  }).ToList();
			//ViewBag.v1 = sehirlistesii;
			////return View(smv);
			//return View();

			//List<SelectListItem> liste = new List<SelectListItem>();

			//Sehirler sehir1 = new Sehirler { ID = 1, name = "İstanbul" };
			//SelectListItem item1 = new SelectListItem { Text = sehir1.name, Value = sehir1.ID.ToString() };
			//liste.Add(item1);

			//Sehirler sehir2 = new Sehirler { ID = 2, name = "Ankara" };
			//SelectListItem item2 = new SelectListItem { Text = sehir2.name, Value = sehir2.ID.ToString() };
			//liste.Add(item2);

			//Sehirler sehir3 = new Sehirler { ID = 3, name = "Kocaeli" };
			//SelectListItem item3 = new SelectListItem { Text = sehir3.name, Value = sehir3.ID.ToString() };
			//liste.Add(item3);

			//SehirlerModelView smv=new SehirlerModelView();
			//smv.sehirlers = liste;
			//smv.SelectedCityId = 1;
			//List<SelectListItem> sehirlistesii = (from x in smv.sehirlers
			//									  select new SelectListItem
			//									  {
			//										  Text = x.Text,
			//										  Value = x.Value.ToString()
			//									  }).ToList();
			//ViewBag.v1 = sehirlistesii;
			//return View(smv);
			return View();
		}

		[HttpPost] //httpget ile aynı olmalıdır adı, httppost paramtere almalı
		public IActionResult Index(Writer p)
		{
			
			//SehirlerModelView smv = new SehirlerModelView();
			WriterValidator vm = new WriterValidator();
			ValidationResult results = vm.Validate(p);
			if (results.IsValid)
			{
				if(p.WriterAbout==p.WriterPassword)
				{
					p.WriterStatus = true;
					p.WriterAbout = "Deneme Test";
					wm.WriterAdd(p);
					return RedirectToAction("Index", "Blog");
					//asp - controller = "Register" asp - action = "Index"
				}
				else
				{
					//ViewBag.v3 = "Şifreler uyuşmuyor.";
					ModelState.AddModelError("Password2", "Şifreler uyuşmuyor.");
				}


			}
			else
			{
				foreach (var item in results.Errors)
				{
					
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
					
				}
			}
			//ModelState.Clear();
			return View();



		}
	}
}
