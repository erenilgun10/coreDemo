﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);

		void BlogUpdate(Blog blog);

		void BlogDelete(Blog blog);

		List<Blog> GetList();

		Blog GetById(int id);

		List<Blog> GetBlockListWithCategory();

		List<Blog> GetBlogListByWriter(int id);
	}
}
