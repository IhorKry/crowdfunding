using System.Collections.Generic;
using System.Linq;
using crowdfunding.Data;
using crowdfunding.Models;

namespace crowdfunding.Services
{
    public class BackerService
    {
        private CrowdfundingDbContext Context;

        public BackerService(CrowdfundingDbContext context)
        {
            Context = context;
        }

        public List<Backer> All()
        {
            return Context.Backers.ToList();
        }

        public Backer Create(Backer backer)
        {
            Context.Backers.Add(backer);
            Context.SaveChanges();
            return backer;
        }
    }
}