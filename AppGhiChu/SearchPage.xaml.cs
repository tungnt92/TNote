using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppGhiChu.Helper;
using AppGhiChu.Model;

namespace AppGhiChu
{
    public partial class SearchPage : PhoneApplicationPage
    {
        public SearchPage()
        {
            InitializeComponent();
            //this.Loaded += SearchPage_Loaded;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (tbSearch.Text == "")
            {
                return;
            }
            else
            {
                DatabaseHelper h = new DatabaseHelper();
                List.ItemsSource = h.SearchContacts(tbSearch.Text);
            }
        }


        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbSearch.Text=="")
            {
                List.ItemsSource.Clear();
            }
            else
            {
                DatabaseHelper h = new DatabaseHelper();
                List.ItemsSource = h.SearchContacts(tbSearch.Text);
            }
        }
        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailPage.xaml?id=" + ((GhiChu)List.SelectedItem).Id, UriKind.Relative));
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}