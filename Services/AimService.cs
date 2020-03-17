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

        public List<Aim> GetAims()
        {
            return Context.Aims.ToList();
        }

        public Aim CreateAim(Aim aim)
        {
            Context.Aims.Add(aim);
            Context.SaveChanges();
            return aim;
        }

        public Aim GetAimById(int id)
        {
            return Context.Aims.Find(id);
        }

        public void DeleteAimById(Aim aim)
        {
            Context.Aims.Remove(aim);
            Context.SaveChanges();
        }
    }
}