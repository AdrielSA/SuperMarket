using System;
using System.Collections.Generic;
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

        public IEnumerable<CoreBusiness.Entities.Transaction> Execute(string cashierName)
        {
            return _unitOfWork.TransactionRepository.GetByDay(cashierName, DateTime.Now);
        }
    }
}
