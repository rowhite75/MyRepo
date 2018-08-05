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
            List<MonthlyTotal> ytdTotals = new List<MonthlyTotal>();
            ytdTotals.Add(new MonthlyTotal { Month = "January", MonthlyExpenses = 4000.00M, MontlyIncome = 3000.00M });
            ytdTotals.Add(new MonthlyTotal { Month = "Febuary", MonthlyExpenses = 3030.00M, MontlyIncome = 1050.00M });
            List<Income> incomes = FinAppService.Service.Instance.GetIncomes();


            TotalsList.ItemsSource = ytdTotals;
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(dashboard));
        }
    }
}
