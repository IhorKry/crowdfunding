using System;
using System.ComponentModel.DataAnnotations;

namespace crowdfunding.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Aim is required")]
        public Aim Aim { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Backer is required")]
        public Backer Backer { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        public Transaction()
        {
        }

        public Transaction(Aim aim, decimal amount, Backer backer, DateTime date)
        {
            Aim = aim;
            Amount = amount;
            Backer = backer;
            Date = date;
        }
    }
}