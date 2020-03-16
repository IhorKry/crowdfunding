using System.Collections.Generic;

namespace crowdfunding.Models
{
    public class Founder
    {
        public int Id { get; set; }
        public List<Aim> Aims { get; set; }

        public Founder()
        {
            Aims = new List<Aim>();
        }
    }
}