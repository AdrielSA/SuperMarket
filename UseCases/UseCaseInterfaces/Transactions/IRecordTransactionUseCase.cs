using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Transactions
{
    public interface IRecordTransactionUseCase
    {
        Task Execute(string cashierName, int productId, int qty);
    }
}
