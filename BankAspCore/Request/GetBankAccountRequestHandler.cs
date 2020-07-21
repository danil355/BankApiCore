using Amazon.Runtime.Internal;
using BankAspCore.Data;
using Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAspCore.Request
{
    public class GetBankAccountRequest : IRequest<BankAccount>
    {
        private readonly ApplicationDbContext _context;
        public int AccountId { get; set; }
        public IList<BankAccount> BankAccounts { get; set; }
        public GetBankAccountRequest(int id)
        {
            AccountId = id;
        }
        
    }
}
