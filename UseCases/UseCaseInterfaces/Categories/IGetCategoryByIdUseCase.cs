﻿using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}