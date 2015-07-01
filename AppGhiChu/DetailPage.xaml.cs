using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Scheduler;
using AppGhiChu.Model;
using AppGhiChu.Helper;
using System.Globalization;
using System.Windows.Input;

namespace AppGhiChu
{
    public partial class DetailPage : PhoneApplicationPage
    {
        private int id, first = 0;
        private GhiChu ghichu;
        public DetailPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (first == 0)
            {
                string pm;
                NavigationContext.QueryString.TryGetValue("id", out pm);
                DatabaseHelper help = new DatabaseHelper();
                ghichu = help.ReadContact(Convert.ToInt32(pm));
                first = 1;
                id = ghichu.Id;
                tbxTitle.Text = ghichu.Title;
                tbxContent.Text = ghichu.Content;
                cbComplete.IsChecked = ghichu.Complete;
                datePicker.Value = ghichu.Time;
                timePicker.Value = ghichu.Time;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DatabaseHelper help = new DatabaseHelper();
            help.DeleteContact(id);
            if (ScheduledActionService.Find(ghichu.Id.ToString()) != null)
            {
                ScheduledActionService.Remove(ghichu.Id.ToString());
            }
            //NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            NavigationService.GoBack();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (tbxTitle.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.");
                return;
            }
            GhiChu u = new GhiChu();
            u.Id = id;
            u.Title = tbxTitle.Text;
            u.Content = tbxContent.Text;
            string date = String.Format("{0:d}", datePicker.Value) + " " + String.Format("{0:t}", timePicker.Value);
            u.Time = DateTime.ParseExact(date, "M/d/yyyy h:m tt", CultureInfo.InvariantCulture, DateTimeStyles.None);
            if (cbComplete.IsChecked == true)
            {
                if (ScheduledActionService.Find(ghichu.Id.ToString()) != null)
                {
                    ScheduledActionService.Remove(ghichu.Id.ToString());
                }
                u.Complete = true;
                DatabaseHelper help = new DatabaseHelper();
                help.UpdateContact(u);
            }
            else
            {
                if (u.Time <= DateTime.Now)
                {
                    MessageBox.Show("Hạn chót phải sau thời điểm hiện tại.");
                    return;
                }
                DatabaseHelper help = new DatabaseHelper();
                u.Complete = false;
                help.UpdateContact(u);
                Reminder reminder = new Reminder(u.Id.ToString());
                if (u.Title.Length > 35)
                {
                    //u.Title = u.Title.Substring(0, u.Title.IndexOfAny(new char[] { ' ' }, 20)) + "...";
                    u.Title = u.Title.Substring(0, 35) + "...";
                }
                reminder.Title = u.Title;
                reminder.Content = u.Content;
                reminder.BeginTime = u.Time;
                reminder.ExpirationTime = u.Time.AddMinutes(5);
                reminder.NavigationUri = new Uri("/DetailPage.xaml?id=" + u.Id, UriKind.Relative);
                if (ScheduledActionService.Find(ghichu.Id.ToString()) != null)
                {
                    ScheduledActionService.Remove(ghichu.Id.ToString());
                }
                ScheduledActionService.Add(reminder);
            }
            //NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
            NavigationService.GoBack();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                App.Current.Terminate();
            }
        }

        private void ListDt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListDt.SelectedIndex = -1;
        }
    }
}