using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Products
{
    public interface IDeleteProductUseCase
    {
        void Delete(int productId);
    }
}
