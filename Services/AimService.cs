using System.Collections.Generic;
using System.Linq;
using crowdfunding.Data;
using crowdfunding.Models;

namespace crowdfunding.Services
{
    public class AimService
    {
        private CrowdfundingDbContext Context;

        public AimService(CrowdfundingDbContext context)
        {
            Context = context;
        }

        public List<Aim> All()
        {
            return Context.Aims.ToList();
        }

        public Aim Create(Aim aim)
        {
            Context.Aims.Add(aim);
            Context.SaveChanges();
            return aim;
        }

        public Aim GetById(int id)
        {
            return Context.Aims.Find(id);
        }

        public void Delete(Aim aim)
        {
            Context.Aims.Remove(aim);
            Context.SaveChanges();
        }
    }
}