using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAspCore.Models.Intefaces
{
    public interface IBankAccount
    {
        BankAccount GetById(int id);

        IList<BankAccount> GetAll();

        BankAccount Create(BankAccount studentDto);

        BankAccount Update(int id, BankAccount studentDto);
        BankAccount Remove(int id);
    }
}
