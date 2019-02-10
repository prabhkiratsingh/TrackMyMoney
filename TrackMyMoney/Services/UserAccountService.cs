using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using TrackMyMoney.Models;

namespace TrackMyMoney.Services
{
    public class UserAccountService
    {
        private ApplicationDbContext db;
        public UserAccountService(ApplicationDbContext context)
        {
            db = context;
        }

        // Service to create a new UserAccount without view.
        public void CreateUserAccount(string firstName, string lastName, decimal mobile, UserAccount.Genders gender, string userId)
        {
            try
            {
                var userAccount = new UserAccount
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Mobile = mobile,
                    Gender = gender,
                    Balance = (decimal)0, // Initial balance of any user is 0.
                    ApplicationUserId = userId
                };

                db.UserAccounts.Add(userAccount);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw;
            }
        }
    }
}