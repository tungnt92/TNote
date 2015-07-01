using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppGhiChu.Model;
using AppGhiChu.Helper;
using Microsoft.Phone.Scheduler;
using System.Globalization;
using System.Windows.Input;

namespace AppGhiChu
{
    public partial class AddPage : PhoneApplicationPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(tbxTitle.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.");
                return;
            }
            GhiChu u = new GhiChu();
            u.Title = tbxTitle.Text;
            u.Content = tbxContent.Text;
            string date = String.Format("{0:d}", datePicker.Value) + " " + String.Format("{0:t}", timePicker.Value);
            u.Time = DateTime.ParseExact(date, "M/d/yyyy h:m tt", CultureInfo.InvariantCulture, DateTimeStyles.None);
            if (u.Time <= DateTime.Now)
            {
                MessageBox.Show("Hạn chót phải sau thời điểm hiện tại.");
                return;
            }
            u.Complete = false;
            DatabaseHelper help = new DatabaseHelper();
            help.Insert(u);
            if (u.Title.Length > 35)
            {
                u.Title = u.Title.Substring(0, 35) + "...";
            }
            Reminder reminder = new Reminder(u.Id.ToString());
            reminder.Title = u.Title;
            reminder.Content = u.Content;
            reminder.BeginTime = u.Time;
            reminder.NavigationUri = new Uri("/DetailPage.xaml?id=" + u.Id, UriKind.Relative);
            ScheduledActionService.Add(reminder);
            NavigationService.GoBack();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if(NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }


        private void ListAdd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListAdd.SelectedIndex = -1;
        }
    }
}