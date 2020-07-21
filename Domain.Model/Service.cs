using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Service
    {
        public int Id { get; set; }
        public BankCard BankCard { get; set; }
        public int Amount { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
    }
}
