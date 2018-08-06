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

        private Service()
        {
            //prepopulate incomes
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("1-5-2018"), Amount = 2000.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("2-5-2018"), Amount = 2200.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("3-5-2018"), Amount = 2000.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("4-5-2018"), Amount = 2200.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("5-5-2018"), Amount = 2000.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("6-5-2018"), Amount = 2200.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("7-5-2018"), Amount = 2000.00M });
            incomes.Add(new Income { ReceivedDate = DateTime.Parse("8-5-2018"), Amount = 2200.00M });

            //prepopulate bills
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("1-15-2018"), Amount = 215.45M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("1-17-2018"), Amount = 122.25M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("2-5-2018"), Amount = 127.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("2-6-2018"), Amount = 322.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("3-15-2018"), Amount = 215.45M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("3-17-2018"), Amount = 122.25M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("4-5-2018"), Amount = 127.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("4-6-2018"), Amount = 322.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("5-15-2018"), Amount = 215.45M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("5-17-2018"), Amount = 122.25M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("6-5-2018"), Amount = 127.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("6-6-2018"), Amount = 322.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("7-15-2018"), Amount = 215.45M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("7-17-2018"), Amount = 122.25M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("8-5-2018"), Amount = 127.00M });
            bills.Add(new Bill { ReceivedDate = DateTime.Parse("8-6-2018"), Amount = 322.00M });
        }

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
        private List<Bill> bills = new List<Bill>();

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

        public void AddBill(DateTime receivedDate, decimal amount, string name)
        {
            this.bills.Add(new Bill { ReceivedDate = receivedDate, Amount = amount, Name = name });
        }

        public List<Income> GetIncomes()
        {
            return this.incomes;
        }

        public List<Bill> GetBills()
        {
            return this.bills;
        }

        public MonthlyTotal GetMonthlyTotal(DateTime date)
        {
            return new MonthlyTotal
            {
                Month = date.ToString("MMMM"),
                MonthlyExpenses = bills.FindAll(bill => bill.ReceivedDate.Month == date.Month).ToList().Sum(y => y.Amount),
                MontlyIncome = incomes.FindAll(income => income.ReceivedDate.Month == date.Month).ToList().Sum(z => z.Amount)
            };
        }
    }
}
