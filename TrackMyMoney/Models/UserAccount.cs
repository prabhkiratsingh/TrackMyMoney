using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackMyMoney.Models
{
    // Corresponds to separate users
    public class UserAccount
    {
        // Only fixed values are allowed.
        public enum Genders
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("\\d{10}")] // Regular expression denoting that it can be of only 10 digits.
        public decimal Mobile { get; set; }
        
        [Required(ErrorMessage = "Please make one selection.")]
        public Genders Gender { get; set; }

        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        // Creating a foreign key with ApplicationUser.
        [Required]
        public string ApplicationUserId { get; set; }

        // Easy access of Transactions by that particular UserAccount.
        public virtual ICollection<Transaction> Transactions { set; get; }
    }
}