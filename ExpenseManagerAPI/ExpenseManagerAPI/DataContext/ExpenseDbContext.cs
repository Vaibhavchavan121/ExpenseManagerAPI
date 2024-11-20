using ExpenseManagerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagerAPI.DataContext
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}
