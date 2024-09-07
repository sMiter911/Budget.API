using Budget.API.Repository.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models.Data_Models
{
    public class FinancialTransactionSummary
    {
        public Guid Id { get; set; }

        [Required]
        public Guid FinancialTransactionId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        public FinancialTransaction FinancialTransaction { get; set; }

        public string? RequestPayload { get; set; }

        public string? ResponsePayload { get; set; }

        public string CurrencyCode { get; set; }
    }
}
