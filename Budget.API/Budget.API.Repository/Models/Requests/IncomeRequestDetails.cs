using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models.Requests
{
    public class IncomeRequestDetails
    {

        private decimal _amount;

        public Guid Id { get; set; }

        [Required]
        public decimal Amount
        {
            get => _amount;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Amount must be greater than zero");
                }
                _amount = value;
            }
        }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Source { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        public bool IsRecurring { get; set; }

        public string Notes { get; set; }

        [StringLength(50)]
        public string IncomeType { get; set; }

        public string CurrencyCode { get; set; }
    }
}
