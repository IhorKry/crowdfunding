using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crowdfunding.Models
{
    public class Aim
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name length must be more then 3")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SumToClose is required")]
        public decimal SumToClose { get; set; }
        public List<Transaction> TransactionHistory { get; set; }

        public Aim()
        {
            TransactionHistory = new List<Transaction>();
        }

        public Aim(string name, decimal sumToClose) : this()
        {
            Name = name;
            SumToClose = sumToClose;
        }
    }
}