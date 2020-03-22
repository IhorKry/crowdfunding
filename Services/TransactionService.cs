using System.Collections.Generic;
using System.Linq;
using crowdfunding.Data;
using crowdfunding.Models;

namespace crowdfunding.Services
{
    public class TransactionService
    {
        private CrowdfundingDbContext Context;

        public TransactionService(CrowdfundingDbContext context)
        {
            Context = context;
        }

        public List<Transaction> All()
        {
            return Context.Transactions.ToList();
        }

        public Transaction Create(Transaction transaction)
        {
            Context.Transactions.Add(transaction);
            Context.SaveChanges();
            return transaction;
        }

        public bool IsAimExist(int id)
        {
            return Context.Aims.Any(aim => aim.Id == id);
        }

        public bool IsBackerExist(int id)
        {
            return Context.Backers.Any(backer => backer.Id == id);
        }
    }
}