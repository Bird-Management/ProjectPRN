﻿using Respository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Services
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
                var checkLogin = this._context.Account.Where(x => x.User.Equals(username) && x.Pass.Equals(password)).FirstOrDefault();
                if (checkLogin == null)
                {
                    throw new Exception("Invalid account");
                }

                return checkLogin;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Account> GetAccounts()
        {
            try
            {
                var listAccounts = this._context.Account.Select(x => new Account { 
                    User = x.User, 
                    Pass = x.Pass, 
                    IsAdmin = x.IsAdmin, 
                    IsSell = x.IsSell,
                    UId = x.UId
                })
                .ToList();
                if (listAccounts != null)
                {
                    return listAccounts;
                }
                return null;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account NewAccountAdmin( string username, string password)
        {
            try
            {
                var account = new Account();
                account.User = username;
                account.Pass = password;
                account.IsAdmin = true;
                account.IsSell = false;

                this._context.Add(account);
                this._context.SaveChanges();


                return account;
            }catch(Exception ex)
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
                    _context.Remove(account);
                    _context.SaveChanges(); 
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
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

                this._context.Add(account);
                this._context.SaveChanges();


                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
