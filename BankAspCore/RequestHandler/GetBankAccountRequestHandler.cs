using BankAspCore.Models.Intefaces;
using BankAspCore.Request;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BankAspCore.RequestHandler
{
    public class GetBankAccountRequestHandler : IRequestHandler<GetBankAccountRequest, BankAccount>
    {
        private readonly IBankAccount _bankAccount;
        public GetBankAccountRequestHandler(IBankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public async Task<BankAccount> Handle(GetBankAccountRequest request, CancellationToken cancellationToken)
        {
            var result = _bankAccount.GetById(request.AccountId);
            return result;
        }
    }
}
