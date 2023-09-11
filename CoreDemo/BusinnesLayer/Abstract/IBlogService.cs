using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> GetList(); //bu kullanılmıyor.
		Blog GetById(int id);
		List<Blog> GetBlogListByCategory();
		List<Blog> GetBlogListByWriter(int id);
	}
}
