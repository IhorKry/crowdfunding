using System.ComponentModel.DataAnnotations;

namespace crowdfunding.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public int FounderId { get; set; }
        public int BackerId { get; set; }

        public User()
        {
        }

        public User(string name, int founderId, int backerId)
        {
            Name = name;
            FounderId = founderId;
            BackerId = backerId;
        }
    }
}