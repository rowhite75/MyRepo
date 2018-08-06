using FinAppCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace fin_app_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ytd : Page
    {
        

        public ytd()
        {
            this.InitializeComponent();
            List<object> ytdTotals = new List<object>();
            List<Income> incomes = FinAppService.Service.Instance.GetIncomes();
            List<Bill> bills = FinAppService.Service.Instance.GetBills();
            List<int> months = bills.Select(a => a.ReceivedDate.Month).Distinct().OrderByDescending(b => b).ToList();

            foreach (var month in months)
            {
                ytdTotals.Add(new {
                    Month = bills.Find(a => a.ReceivedDate.Month == month).ReceivedDate.ToString("MMMM"),
                    MonthlyExpenses = bills.FindAll(bill => bill.ReceivedDate.Month == month).ToList().Sum(y => y.Amount).ToString("C"),
                    MontlyIncome = incomes.FindAll(income => income.ReceivedDate.Month == month).ToList().Sum(z => z.Amount).ToString("C")
                });
            }

            TotalsList.ItemsSource = ytdTotals;
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            new MyWindowUtility().Show(new dashboard());
        }
    }
}
