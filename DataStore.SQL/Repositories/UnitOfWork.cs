using DataStore.SQL.Context;
using UseCases.DataStoreInterfaces;

namespace DataStore.SQL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketContext _context;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly ITransactionRepository _transactionRepository;

        public UnitOfWork(MarketContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);

        public IProductRepository ProductRepository => _productRepository ?? new ProductRepository(_context);

        public ITransactionRepository TransactionRepository => _transactionRepository ?? new TransactionRepository(_context);
    }
}
