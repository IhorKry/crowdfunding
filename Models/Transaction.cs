using System;
using System.ComponentModel.DataAnnotations;

namespace crowdfunding.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "AimId is required")]
        public int AimId { get; set; }
        [Required(ErrorMessage = "BackerId is required")]
        public int BackerId { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        public Transaction()
        {
        }

        public Transaction(int aimId, int backerId, decimal amount, DateTime date)
        {
            AimId = aimId;
            BackerId = backerId;
            Amount = amount;
            Date = date;
        }
    }
}