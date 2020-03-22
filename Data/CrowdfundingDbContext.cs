using crowdfunding.Models;
using Microsoft.EntityFrameworkCore;

namespace crowdfunding.Data
{
    public class CrowdfundingDbContext : DbContext
    {
        public CrowdfundingDbContext(DbContextOptions<CrowdfundingDbContext> options) : base(options)
        {
        }

        public DbSet<Aim> Aims { get; set; }
        public DbSet<Backer> Backers { get; set; }
        public DbSet<Founder> Founders { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}