using Domain.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAspCore.ViewModels
{
    public class BankViewModel
    {
        private IdentityUser Name { get; set; }
        public string Number { get; set; }
        public IList<BankCard> BankCards { get; set; }
    }
}
