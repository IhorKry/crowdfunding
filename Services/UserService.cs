using System.Collections.Generic;
using System.Linq;
using crowdfunding.Data;
using crowdfunding.Models;

namespace crowdfunding.Services
{
    public class UserService
    {
        private CrowdfundingDbContext Context;

        public UserService(CrowdfundingDbContext context)
        {
            Context = context;
        }

        public List<User> All()
        {
            return Context.Users.ToList();
        }

        public User Create(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return user;
        }

        public User GetById(int id)
        {
            var user = Context.Users.Find(id);
            return user;
        }

        public void Delete(User user)
        {
            Context.Users.Remove(user);
            Context.SaveChanges();
        }

        public User ActivateFounder(User user)
        {
            var founder = new Founder();

            Context.Founders.Add(founder);
            Context.SaveChanges();

            user.FounderId = founder.Id;
            Context.SaveChanges();

            return user;
        }
    }
}