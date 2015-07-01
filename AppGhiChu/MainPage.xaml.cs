using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppGhiChu.Resources;
using AppGhiChu.Model;
using AppGhiChu.Helper;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Scheduler;

namespace AppGhiChu
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            DatabaseHelper help = new DatabaseHelper();
            var l = help.ReadContacts();
            foreach (var gc in l.ToArray())
            {
                if (gc.Time < DateTime.Now)
                {
                    if (ScheduledActionService.Find(gc.Id.ToString()) != null)
                    {
                        ScheduledActionService.Remove(gc.Id.ToString());
                    }
                }
            }
            List.ItemsSource = l;
            ListLS.ItemsSource = help.ReadContactsComplete();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                NavigationService.Navigate(new Uri("/DetailPage.xaml?id=" + ((GhiChu)List.SelectedItem).Id, UriKind.Relative));
            }
            List.SelectedIndex = -1;
        }
        private void ListLS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListLS.SelectedItem != null)
            {
                NavigationService.Navigate(new Uri("/DetailPage.xaml?id=" + ((GhiChu)ListLS.SelectedItem).Id, UriKind.Relative));
            }
            ListLS.SelectedIndex = -1;

        }

        private void Describe_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/DescribePage.xaml", UriKind.Relative));
        }


        private void Search_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SearchPage.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (MainPivot.SelectedIndex)
            {
                case 0:
                    Select0();
                    break;
                case 1:
                    Select1();
                    break;
                default:
                    break;
            }
        }

        private void Icon0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Select0();
        }

        private void Icon1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Select1();
        }

        void Select0()
        {
            icon0.Source = new BitmapImage(new Uri("/Assets/DateCheck.png", UriKind.Relative));
            icon1.Source = new BitmapImage(new Uri("/Assets/Tab-History.png", UriKind.Relative));
            MainPivot.SelectedIndex = 0;
        }

        void Select1()
        {
            icon1.Source = new BitmapImage(new Uri("/Assets/Tab-HistoryCheck.png", UriKind.Relative));
            icon0.Source = new BitmapImage(new Uri("/Assets/Date.png", UriKind.Relative));
            MainPivot.SelectedIndex = 1;
        }
    }
}