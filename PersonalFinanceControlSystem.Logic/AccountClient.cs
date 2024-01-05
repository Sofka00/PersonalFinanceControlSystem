using PersonalFinanceControlSystem.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceControlSystem.Logic
{
    public class AccountClient
    {
        public List<AccountModel> Accunts { get;private set; }
        public AccountClient() 
        {
            Accunts = new List<AccountModel>();
        }
        public void AddAccount(AccountModel account)
        {
            Accunts.Add(account);
        }
    }
}
