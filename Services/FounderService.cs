using System.Collections.Generic;
using System.Linq;
using crowdfunding.Data;
using crowdfunding.Models;

namespace crowdfunding.Services
{
    public class FounderService
    {
        private CrowdfundingDbContext Context;

        public FounderService(CrowdfundingDbContext context)
        {
            Context = context;
        }

        public List<Founder> All()
        {
            return Context.Founders.ToList();
        }

        public Founder Create(Founder founder)
        {
            Context.Founders.Add(founder);
            Context.SaveChanges();
            return founder;
        }

        public Founder GetById(int id)
        {
            return Context.Founders.Find(id);
        }

        public void Delete(Founder founder)
        {
            Context.Founders.Remove(founder);
            Context.SaveChanges();
        }

        public IQueryable<Aim> GetAims(int id)
        {
            var aims = Context.Aims.Where(aim => aim.FounderId == id);
            return aims;
        }
    }
}