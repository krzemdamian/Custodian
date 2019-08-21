using System;

namespace Custodian.Domain.Entities
{
    public class Transaction<T> where T : Account
    {

        public int Id { get; set; }
        public T SourceAccount { get; set; }
        public T TargetAccount { get; set; }
        public DateTime ExecutionDateTime { get; set; }
    }
}