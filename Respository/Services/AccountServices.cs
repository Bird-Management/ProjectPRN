using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Repository.Services;
using Respository.Models;

namespace Repository.Services
{
    public class AccountServices
    {
        private readonly BirdManagementContext _context;

        public AccountServices(BirdManagementContext context)
        {
            _context = context;
        }

        public Account LoginAccount(string username, string password)
        {
            try
            {
                var checkLogin = _context.Account.FirstOrDefault(x => x.UserName.Equals(username) && x.Password.Equals(password));
                if (checkLogin == null)
                {
                    throw new Exception("Invalid account");
                }

                return checkLogin;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Account> GetAccounts()
        {
            try
            {
                var listAccounts = _context.Account.Select(x => new Account
                {
                    AccountId = x.AccountId,
                    UserName = x.UserName,
                    Password = x.Password,
                    Role = x.Role,
                    Email = x.Email,
                    Phone = x.Phone,
                })
                .ToList();

                return listAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountAdmin(string accountID, string username, string password, string role, string email, string phone)
        {

            try
            {
                var account = new Account();
                account.AccountId = accountID;
                account.UserName = username;
                account.Password = password;
                account.Role = role;
                account.Email = email;
                account.Phone = phone;

                _context.Account.Add(account);
                _context.SaveChanges();

                return account;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsValidAccountIDFormat(string accountID)
        {
            // Regular expression pattern for accountID validation
            string pattern = @"^A-(0[1-9]|[1-9][0-9]*)$";

            // Check if the accountID matches the pattern
            return Regex.IsMatch(accountID, pattern);
        }

        public bool AccountIDExists(string accountID)
        {
            try
            {
                return _context.Account.Any(a => a.AccountId == accountID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UsernameExists(string username)
        {
            try
            {
                return _context.Account.Any(a => a.UserName == username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        public bool IsValidPhoneNumber(string phone)
        {
            // Regular expression pattern for phone number validation
            string pattern = @"^\d{10}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phone, pattern);
        }

        public bool DeleteAccountAdmin(string username, string password)
        {
            try
            {
                var account = _context.Account.FirstOrDefault(a => a.UserName == username && a.Password == password);
                if (account != null)
                {
                    _context.Account.Remove(account);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAccountAdmin(Account account)
        {
            try
            {
                var existingAccount = _context.Account.FirstOrDefault(a => a.AccountId == account.AccountId);
                if (existingAccount != null)
                {
                    existingAccount.UserName = account.UserName;
                    existingAccount.Password = account.Password;
                    existingAccount.Role = account.Role;
                    existingAccount.Email = account.Email;
                    existingAccount.Phone = account.Phone;

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountSeller(string username, string password, string role, string email, string phone)
        {
            try
            {
                var account = new Account();
                account.UserName = username;
                account.Password = password;
                account.Role = role;
                account.Email = email;
                account.Phone = phone;

                _context.Account.Add(account);
                _context.SaveChanges();

                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountCustomer(string username, string password, string role, string email, string phone)
        {
            try
            {
                var account = new Account();
                account.UserName = username;
                account.Password = password;
                account.Role = role;
                account.Email = email;
                account.Phone = phone;

                _context.Account.Add(account);
                _context.SaveChanges();

                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
