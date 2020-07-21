using System;

namespace Domain.Model
{
    public class BankCard
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string ValidPeriod { get; set; }
        public string CardHolder { get; set; }
        public int CVC { get; set; }
        public int Amount { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
