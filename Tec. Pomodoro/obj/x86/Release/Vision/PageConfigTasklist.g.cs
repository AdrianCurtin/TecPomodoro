﻿#pragma checksum "F:\Github\TecPomodoro\Tec. Pomodoro\Vision\PageConfigTasklist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "70EC103842BBC66A30F4D3DCA8A3358E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tec.Pomodoro.Vision
{
    partial class PageConfigTasklist : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Vision\PageConfigTasklist.xaml line 16
                {
                    this.ShowPage = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2: // Vision\PageConfigTasklist.xaml line 27
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Vision\PageConfigTasklist.xaml line 37
                {
                    this.ListTask = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4: // Vision\PageConfigTasklist.xaml line 70
                {
                    this.BtNext = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtNext).Click += this.BtNext_Click;
                }
                break;
            case 5: // Vision\PageConfigTasklist.xaml line 59
                {
                    this.TxtTask = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.TxtTask).KeyDown += this.TxtTask_KeyDown;
                }
                break;
            case 6: // Vision\PageConfigTasklist.xaml line 60
                {
                    this.BtAdd = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtAdd).Click += this.BtAdd_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

