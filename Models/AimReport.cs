using System.Collections.Generic;

namespace crowdfunding.Models
{
    public class AimReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public List<TransactionReport> Transactions { get; set; }
        public bool Achieved { get; set; }

        public AimReport(int id, string name, decimal totalAmount, decimal currentAmount, List<TransactionReport> transactions, bool achieved)
        {
            Id = id;
            Name = name;
            TotalAmount = totalAmount;
            CurrentAmount = currentAmount;
            Transactions = transactions;
            Achieved = achieved;
        }
    }
}