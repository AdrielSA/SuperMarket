using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Transactions;

namespace UseCases.TransactionsUseCases
{
    public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTodayTransactionsUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CoreBusiness.Entities.Transaction>> Execute(string cashierName)
        {
            return await _unitOfWork.TransactionRepository.GetByDay(cashierName, DateTime.Now);
        }
    }
}
