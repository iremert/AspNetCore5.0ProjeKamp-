using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
//using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		//CategoryRepository categoryRepository=new CategoryRepository();
		//GenericRepository<Category> repo = new GenericRepository<Category>();
		//EfCategoryRepository efCategoryRepository;

		ICategoryDal _categoryDal;
		//public CategoryManager()
		//{
		//	efCategoryRepository = new EfCategoryRepository();
		//}

		public CategoryManager(ICategoryDal categoryDal)
		{
			this._categoryDal = categoryDal;
		}

		public void CategoryAdd(Category category)
		{
			//if(category.CategoryName!="" && category.CategoryDescription!="" && category.CategoryName.Length>=5 && category.CategoryStatus==true)
			//{
			//	categoryRepository.AddCategory(category);
			//}
			//else
			//{
			//	// hata mesajı
			//}


			//efCategoryRepository.Insert(category);
			_categoryDal.Insert(category);
		}

		public void CategoryDelete(Category category)
		{
			//if(category.CategoryID != 0)
			//{
			//	repo.Delete(category);	
			//}
			_categoryDal.Delete(category);
		}

		public void CategoryUpdate(Category category)
		{
			_categoryDal.Update(category);
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}
	}
}
