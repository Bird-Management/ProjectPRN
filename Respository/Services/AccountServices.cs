using System;
using System.Collections.Generic;
using System.Linq;
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
                var checkLogin = _context.Account.FirstOrDefault(x => x.User.Equals(username) && x.Pass.Equals(password));
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
                    User = x.User,
                    Pass = x.Pass,
                    IsAdmin = x.IsAdmin,
                    IsSell = x.IsSell,
                    UId = x.UId
                })
                .ToList();

                return listAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountAdmin(string username, string password)
        {
            try
            {
                var account = new Account();
                account.User = username;
                account.Pass = password;
                account.IsAdmin = true;
                account.IsSell = false;

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
                var account = _context.Account.FirstOrDefault(a => a.User == username && a.Pass == password);
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

        public Account NewAccountSeller(string username, string password)
        {
            try
            {
                var account = new Account();
                account.User = username;
                account.Pass = password;
                account.IsAdmin = false;
                account.IsSell = true;

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
                var existingAccount = _context.Account.FirstOrDefault(a => a.UId == account.UId);
                if (existingAccount != null)
                {
                    existingAccount.User = account.User;
                    existingAccount.Pass = account.Pass;
                    existingAccount.IsAdmin = account.IsAdmin;
                    existingAccount.IsSell = account.IsSell;

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
