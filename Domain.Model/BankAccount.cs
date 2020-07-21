using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public string ValidPeriod { get; set; }
        public int BankCards { get; set; }
    }
}
