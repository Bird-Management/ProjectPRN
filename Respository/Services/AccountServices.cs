using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
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

        public Account NewAccountAdmin(string username, string password, string role, string email, int phone)
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

        public Account NewAccountSeller(string username, string password, string role, string email, int phone)
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

        public Account NewAccountCustomer(string username, string password, string role, string email, int phone)
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

    }
}
