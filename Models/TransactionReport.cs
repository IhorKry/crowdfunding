using System;

namespace crowdfunding.Models
{
    public class TransactionReport
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public TransactionReport(int id, string username, decimal amount, DateTime date)
        {
            Id = id;
            Username = username;
            Amount = amount;
            Date = date;
        }
    }
}