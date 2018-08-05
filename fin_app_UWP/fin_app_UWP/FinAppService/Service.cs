using FinAppCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAppService
{
    public class Service
    {
        private static Service instance;

        private Service() { }

        public static Service Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Service();
                }
                return instance;
            }
        }

        private List<UserAccount> userAccounts = new List<UserAccount>();
        private List<Income> incomes = new List<Income>();

        public void CreateAccount(string username, string password)
        {
            UserAccount account = new UserAccount
            {
                UserName = username,
                Password = password
            };

            userAccounts.Add(account);
        }

        public bool IsValidAccount(string username, string password)
        {
            return this.GetAccount(username, password) != null;
        }

        public UserAccount GetAccount(string username, string password)
        {
            return userAccounts.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

        public void AddIncomeAmount(DateTime receivedDate, decimal amount)
        {
            this.incomes.Add(new Income { ReceivedDate = receivedDate, Amount = amount });
        }

        public List<Income> GetIncomes()
        {
            return this.incomes;
        }
    }
}
