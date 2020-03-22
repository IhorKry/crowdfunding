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

        public bool IsFounderExist(int id)
        {
            return Context.Founders.Any(founder => founder.Id == id);
        }

        public AimReport GenerateReport(Aim aim)
        {
            var transactions = Context.Transactions
                .Where(transaction => transaction.AimId == aim.Id)
                .OrderBy(transaction => transaction.Date)
                .ToList();
            var currentAmount = transactions.Sum(transaction => transaction.Amount);
            var prettyTransactions = new List<TransactionReport>();
            bool isAchieved = currentAmount >= aim.Amount;

            foreach (var transaction in transactions)
            {
                var username = Context.Users.First(user => user.BackerId == transaction.BackerId).Name;
                var prettyTransaction = new TransactionReport(transaction.Id, username, transaction.Amount, transaction.Date);
                prettyTransactions.Add(prettyTransaction);
            }

            return new AimReport(aim.Id, aim.Name, aim.Amount, currentAmount, prettyTransactions, isAchieved);
        }
    }
}