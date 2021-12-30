using CoreBusiness.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Categories;

namespace UseCases.CategoriesUseCase
{
    public class GetCategoriesUseCase : IGetCategoriesUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoriesUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> Execute()
        {
            return await _unitOfWork.CategoryRepository.GetCategories();
        }
    }
}
