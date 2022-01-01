using CoreBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStoreInterfaces;
using UseCases.UseCaseInterfaces.Transactions;

namespace UseCases.TransactionsUseCases
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTransactionsUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return _unitOfWork.TransactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
