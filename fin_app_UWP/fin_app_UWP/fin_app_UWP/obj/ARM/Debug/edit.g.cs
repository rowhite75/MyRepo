﻿#pragma checksum "C:\Users\roger\Documents\WES\fin_app_UWP\fin_app_UWP\fin_app_UWP\edit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B273CEEF16606D91775CDB72145E0015"
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
    partial class edit : 
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
            case 2: // edit.xaml line 12
                {
                    this.income_txt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // edit.xaml line 13
                {
                    this.income_add_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4: // edit.xaml line 14
                {
                    this.add_txt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // edit.xaml line 15
                {
                    this.bill_name_txt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // edit.xaml line 17
                {
                    this.add_bill_amount = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // edit.xaml line 18
                {
                    this.add_bill_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // edit.xaml line 22
                {
                    this.home_btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.home_btn).Click += this.home_btn_Click;
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

