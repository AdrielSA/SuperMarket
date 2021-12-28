﻿using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IEditProductUseCase
    {
        void Execute(Product product);
    }
}