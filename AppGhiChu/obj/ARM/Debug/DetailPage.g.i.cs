﻿#pragma checksum "H:\AppGhiChu\AppGhiChu\DetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D33340D5C0D5E2E6B458CCF791B996F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppGhiChu {
    
    
    public partial class DetailPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox ListDt;
        
        internal System.Windows.Controls.TextBlock tbkFullName;
        
        internal System.Windows.Controls.TextBlock tbkAddress;
        
        internal System.Windows.Controls.TextBlock tbkPassword;
        
        internal System.Windows.Controls.TextBlock tbkComple;
        
        internal System.Windows.Controls.TextBox tbxTitle;
        
        internal System.Windows.Controls.TextBox tbxContent;
        
        internal Microsoft.Phone.Controls.DatePicker datePicker;
        
        internal Microsoft.Phone.Controls.TimePicker timePicker;
        
        internal System.Windows.Controls.CheckBox cbComplete;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Update;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Delete;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Quit;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppGhiChu;component/DetailPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ListDt = ((System.Windows.Controls.ListBox)(this.FindName("ListDt")));
            this.tbkFullName = ((System.Windows.Controls.TextBlock)(this.FindName("tbkFullName")));
            this.tbkAddress = ((System.Windows.Controls.TextBlock)(this.FindName("tbkAddress")));
            this.tbkPassword = ((System.Windows.Controls.TextBlock)(this.FindName("tbkPassword")));
            this.tbkComple = ((System.Windows.Controls.TextBlock)(this.FindName("tbkComple")));
            this.tbxTitle = ((System.Windows.Controls.TextBox)(this.FindName("tbxTitle")));
            this.tbxContent = ((System.Windows.Controls.TextBox)(this.FindName("tbxContent")));
            this.datePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("datePicker")));
            this.timePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("timePicker")));
            this.cbComplete = ((System.Windows.Controls.CheckBox)(this.FindName("cbComplete")));
            this.Update = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Update")));
            this.Delete = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Delete")));
            this.Quit = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Quit")));
        }
    }
}

