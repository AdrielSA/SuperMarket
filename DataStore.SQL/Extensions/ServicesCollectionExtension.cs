using DataStore.SQL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using UseCases.CategoriesUseCase;
using UseCases.DataStoreInterfaces;
using UseCases.ProductsUseCases;
using UseCases.TransactionsUseCases;
using UseCases.UseCaseInterfaces.Categories;
using UseCases.UseCaseInterfaces.Products;
using UseCases.UseCaseInterfaces.Transactions;

namespace DataStore.SQL.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Injección de dependencias para los repositorios SQL
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Injección de dependencias para los casos de usos (servicios)
            //categorias
            services.AddTransient<IGetCategoriesUseCase, GetCategoriesUseCase>();
            services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
            //procuctos
            services.AddTransient<IGetProductsUseCase, GetProductsUseCase>();
            services.AddTransient<IAddProductUseCase, AddProductUseCase>();
            services.AddTransient<IEditProductUseCase, EditProductUseCase>();
            services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
            services.AddTransient<IGetProductsByCategoryIdUseCase, GetProductsByCategoryIdUseCase>();
            services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddTransient<ISellProductUseCase, SellProductUseCase>();
            //transacciones
            services.AddTransient<IRecordTransactionUseCase, RecordTransactionUseCase>();
            services.AddTransient<IGetTodayTransactionsUseCase, GetTodayTransactionsUseCase>();
            services.AddTransient<IGetTransactionsUseCase, GetTransactionsUseCase>();

            return services;
        }
    }
}
