using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace fin_app_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void pword_reset_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(reset_password));
        }

        private void create_account_Click(object sender, RoutedEventArgs e)
        {
            new MyWindowUtility().Show(new create_account());
        }

        private async void login_Click(object sender, RoutedEventArgs e)
        {
            bool accountValid = FinAppService.Service.Instance.IsValidAccount(this.login_email.Text, this.login_password.Text);
            if (accountValid == true)
            {
                new MyWindowUtility().Show(new dashboard());
            }
            else
            {
                var messageDialog = new MessageDialog("Username or password not valid. Try Again");

                messageDialog.Commands.Add(new UICommand(
                    "Ok",
                    new UICommandInvokedHandler(this.CommandInvokedHandler)));

        

                // Show the message dialog
                await messageDialog.ShowAsync();
            }
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            // Display message showing the label of the command that was invoked
            //rootPage.NotifyUser("The '" + command.Label + "' command has been selected.",
            //    NotifyType.StatusMessage);
        }
    }
}
