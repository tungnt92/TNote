using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Storage;
using Microsoft.Phone.Reactive;
using Newtonsoft.Json;
using AppGhiChu.Model;
using Newtonsoft.Json.Linq;
using System.IO;
using Windows.System;

namespace AppGhiChu
{
    public partial class Description : PhoneApplicationPage
    {
        public Description()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<MoTa> mt = new List<MoTa>();
            mt.Add(new MoTa("Url", "SHTP-TRAINING", "Assets/Item-53e88f6f-42e4-4d2c-ab41-a8d568894434.png", "bingmaps:?cp=10.855064~106.785569&lvl=17"));
            mt.Add(new MoTa("Url", "Địa chỉ: Lô E1 – Khu Công nghệ cao, Xa lộ Hà Nội, Phường Hiệp Phú, Quận 9, TP.HCM", "Assets/location.png", "bingmaps:?cp=10.855064~106.785569&lvl=17"));
            mt.Add(new MoTa("Phone", "Điện thoại: (84-8) 39.322.230 (17) ", "Assets/phoneicon.png", "tel:(84-8) 39.322.230 (17)"));
            mt.Add(new MoTa("Phone", "Hỗ trợ ghi nhớ nội dung công việc và nhắc lịch.", "Assets/ApplicationIcon.png", ""));
            mt.Add(new MoTa("Url", "Tác giả: Duy Thanh", "Assets/User-Monitor.png", ""));
            mt.Add(new MoTa("Url", "Phiên bản: 1.0.0", "Assets/Download.png", ""));
            ListMT.ItemsSource = mt;
        }

        private async void ListMT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListMT.SelectedItem!=null)
            {
                if (((MoTa)ListMT.SelectedItem).Target != "")
                {
                    await Launcher.LaunchUriAsync(new Uri(((MoTa)ListMT.SelectedItem).Target, UriKind.Absolute));
                }
            }
            ListMT.SelectedIndex = -1;
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