using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models.Requests
{
    public class BudgetRequest
    {
        public GroupHeader GroupHeader { get; set; }

        public BudgetRequestDetails BudgetRequestDetails { get; set; }
    }
}
