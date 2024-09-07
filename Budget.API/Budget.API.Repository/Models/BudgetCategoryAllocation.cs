using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models
{
    public class BudgetCategoryAllocation
    {
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        public decimal AllocatedAmount { get; set; }

        public decimal AmountSpent { get; set; }

        public decimal RemainingAmount => AllocatedAmount - AmountSpent;

    }
}
