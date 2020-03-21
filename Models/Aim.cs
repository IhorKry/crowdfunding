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
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "FounderId is required")]
        public int FounderId { get; set; }

        public Aim()
        {
        }

        public Aim(string name, decimal amount, int founderId)
        {
            Name = name;
            Amount = amount;
            FounderId = founderId;
        }
    }
}