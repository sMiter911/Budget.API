using Budget.API.Repository.Models.Data_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository
{
    public class BudgetApiDBContext : DbContext
    {
        public BudgetApiDBContext(DbContextOptions<BudgetApiDBContext> options) : base(options)
        {

        }

        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public DbSet<FinancialTransactionAudit> FinancialTransactionAudits { get; set; }
        public DbSet<FinancialTransactionSummary> FinancialTransactionSummaries { get; set; }
    }
}
