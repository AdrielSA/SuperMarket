using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Transactions;

namespace UseCases.TransactionsUseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecordTransactionUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Execute(string cashierName, int productId, int qty)
        {
            var product = _unitOfWork.ProductRepository.GetProductById(productId);
            _unitOfWork.TransactionRepository.Save(cashierName, productId, product.Name, 
                product.Price.Value, product.Quantity.Value, qty);
        }
    }
}
