using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace fin_app_UWP
{
    public class MyWindowUtility
    {
        public void Show(Page page)
        {
            Frame rootFrame = new Frame();
            rootFrame.Navigate(page.GetType());

            //Place the frame in the current Window and ensure that it is active
            Window.Current.Content = rootFrame;
            Window.Current.Activate();
        }
    }
}
