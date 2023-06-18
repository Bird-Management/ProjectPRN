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
                    IsCustomer = x.IsCustomer,
                    UId = x.UId
<<<<<<< HEAD
<<<<<<< HEAD
                })
=======
                }
                )
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
=======
                }
                )
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
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
                account.IsCustomer = false;

                _context.Account.Add(account);
                _context.SaveChanges();

                return account;
<<<<<<< HEAD
<<<<<<< HEAD

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
=======
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
=======
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
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
                account.IsCustomer = false;

                _context.Account.Add(account);
                _context.SaveChanges();

                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountCustomer(string username, string password)
        {
            try
            {
                var account = new Account();
                account.User = username;
                account.Pass = password;
                account.IsAdmin = false;
                account.IsSell = false;
                account.IsCustomer = true;

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
                    existingAccount.IsCustomer = account.IsCustomer;

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
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
<<<<<<< HEAD
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca
=======
>>>>>>> a8108fc329307eaa5d0b08dc7f66ef35615f2dca

    }
}
