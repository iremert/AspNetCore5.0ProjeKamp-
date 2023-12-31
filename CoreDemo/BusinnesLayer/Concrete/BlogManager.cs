﻿using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListByCategory()
		{
			return _blogdal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogByID(int id)
		{
			return _blogdal.GetListAll(x => x.BlogID == id); //filter kısmı burada yazılmış.
		}

		public List<Blog> GetList()
		{
			return _blogdal.GetListAll();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogdal.GetListAll(x => x.WriterID == id); //filter kısmı burada ıgenericde tanımı var.
		}
	}
}
