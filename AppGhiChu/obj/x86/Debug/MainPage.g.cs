﻿#pragma checksum "C:\Users\duythanh\Documents\Visual Studio 2013\Projects\AppGhiChu\AppGhiChu\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC2C44FDFD69D3972CA5B74BDA265887"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image icon0;
        
        internal System.Windows.Controls.Image icon1;
        
        internal Microsoft.Phone.Controls.Pivot MainPivot;
        
        internal System.Windows.Controls.ListBox List;
        
        internal System.Windows.Controls.ListBox ListLS;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Add;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Search;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppGhiChu;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.icon0 = ((System.Windows.Controls.Image)(this.FindName("icon0")));
            this.icon1 = ((System.Windows.Controls.Image)(this.FindName("icon1")));
            this.MainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("MainPivot")));
            this.List = ((System.Windows.Controls.ListBox)(this.FindName("List")));
            this.ListLS = ((System.Windows.Controls.ListBox)(this.FindName("ListLS")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Add = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Add")));
            this.Search = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Search")));
        }
    }
}

