using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackMyMoney.Models
{
    // A class for adding a transaction like income or expense.
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string Description { get; set; }

        // Date & time is that of the transaction.
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        // Creating a foreign key linking UserAccount.
        public virtual UserAccount UserAccount { get; set; }

        [Required]
        public int UserAccountId { get; set; }
    }
}