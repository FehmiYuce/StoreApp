﻿using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class CategoryManager : ICategoryService
	{
		private readonly IRepositoryManager _repositoryManager;

		public CategoryManager(IRepositoryManager repositoryManager)
		{
			_repositoryManager = repositoryManager;
		}

		public IEnumerable<Category> GetAllCategories(bool trackChanges)
		{
			return _repositoryManager.CategoryRepository.FindAll(trackChanges);
		}
	}
}
