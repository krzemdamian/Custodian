using System;

namespace Custodian.Domain.Entities
{
    public abstract class Account
    {
        public uint Id { get; set; }
        public uint Number { get; set; }
        public decimal Balance { get; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class SavingsAccount : Account
    {
        public double AnnualInterest { get; set; }
        public DateTime CapitalizationDateTime { get; set; }
    }
}
