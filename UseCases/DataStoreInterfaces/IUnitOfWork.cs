namespace UseCases.DataStoreInterfaces
{
    public interface IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; }

        public IProductRepository ProductRepository { get; }

        public ITransactionRepository TransactionRepository { get; }
    }
}
