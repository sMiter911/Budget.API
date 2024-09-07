using Budget.API.Repository.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models.Data_Models
{
    public class FinancialTransactionAudit
    {
        public Guid Id { get; set; }

        [Required]
        public Guid FinancialTransactionId { get; set; }

        [Required]
        public AuditAction Action { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Changes { get; set; }

        // Optional: Include the state before and after the change
        public string? PreviousState { get; set; }
        public string? NewState { get; set; }

        // Navigation property
        public FinancialTransaction FinancialTransaction { get; set; }
    }
}
