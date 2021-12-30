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

        public async Task Execute(string cashierName, int productId, int qty)
        {
            var product = await _unitOfWork.ProductRepository.GetProductById(productId);
            await _unitOfWork.TransactionRepository.Save(cashierName, productId, product.Name, 
                product.Price.Value, product.Quantity.Value, qty);
        }
    }
}
