﻿using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoriesUseCase
    {
        public IEnumerable<Category> Execute();
    }
}
