using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models.Requests
{
    public class BudgetRequestDetails
    {
        public Guid Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public decimal TotalBudget { get; set; }

        public bool IsEstimated { get; set; }

        public List<BudgetCategoryAllocation> CategoryAllocations { get; set; }

        public decimal RemainingTotal => TotalBudget - CategoryAllocations.Sum(ca => ca.AmountSpent);

        public string CurrencyCode { get; set; }
    }
}
