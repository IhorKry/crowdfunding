namespace crowdfunding.Models
{
    public class User
    {
        public int Id { get; set; }
        public int FounderId { get; set; }
        public int BackerId { get; set; }

        public User()
        {
        }

        public User(int founderId, int backerId)
        {
            FounderId = founderId;
            BackerId = backerId;
        }
    }
}