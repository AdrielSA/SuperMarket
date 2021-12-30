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

        public async Task<IEnumerable<Transaction>> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return await _unitOfWork.TransactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
