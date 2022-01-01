using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.Transactions
{
    public interface IRecordTransactionUseCase
    {
        void Execute(string cashierName, int productId, int qty);
    }
}
