﻿#pragma checksum "C:\Users\roger\Documents\MyRepo\fin_app_UWP\fin_app_UWP\fin_app_UWP\dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "88E164EFA53E0568CD8A29F4568E3C9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fin_app_UWP
{
    partial class dashboard : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // dashboard.xaml line 12
                {
                    this.dashboardheader_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // dashboard.xaml line 13
                {
                    this.expense_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // dashboard.xaml line 14
                {
                    this.income_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // dashboard.xaml line 15
                {
                    this.edit_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.edit_btn).Click += this.edit_btn_Click;
                }
                break;
            case 6: // dashboard.xaml line 16
                {
                    this.bills_lv = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7: // dashboard.xaml line 17
                {
                    this.ytd_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ytd_btn).Click += this.ytd_btn_Click;
                }
                break;
            case 8: // dashboard.xaml line 18
                {
                    this.TxtBlockTotalMonthlyExpenses = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // dashboard.xaml line 19
                {
                    this.TxtBlockTotalMonthlyIncome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

