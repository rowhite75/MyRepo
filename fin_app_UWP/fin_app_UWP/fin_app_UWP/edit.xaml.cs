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
    public sealed partial class edit : Page
    {
        public edit()
        {
            this.InitializeComponent();
        }

        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            new MyWindowUtility().Show(new dashboard());
        }

        private void income_add_btn_Click(object sender, RoutedEventArgs e)
        {
            FinAppService.Service.Instance.AddIncomeAmount(this.DatePickerIncomeDate.Date.DateTime, Decimal.Parse(this.income_txt.Text));
        }

        private void add_bill_btn_Click(object sender, RoutedEventArgs e)
        {
            FinAppService.Service.Instance.AddBill(this.DatePickerBillDate.Date.DateTime, Decimal.Parse(this.TextBoxBillAmount.Text), this.TxtBoxBillName.Text);
        }
    }
}
