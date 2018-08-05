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
using FinAppCommon;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace fin_app_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class dashboard : Page
    {
        public dashboard()
        {
            this.InitializeComponent();
            this.TxtBlockTotalMonthlyExpenses.Text = new MonthlyTotal().MonthlyExpenses.ToString("C");
            this.TxtBlockTotalMonthlyIncome.Text = new MonthlyTotal().MontlyIncome.ToString("C");
        }

        private void ytd_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ytd));
        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            new MyWindowUtility().Show(new edit());
        }
    }
}
