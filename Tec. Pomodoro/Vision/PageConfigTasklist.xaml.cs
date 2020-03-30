using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Tec.Pomodoro.Vision
{

    public sealed partial class PageConfigTasklist : Page
    {
        public PageConfigTasklist()
        {
            this.InitializeComponent();
            ShowPage.Begin();
        }

        private bool isConnected;

        private void BtNext_Click(object sender, RoutedEventArgs e)
        {
            string[] tasks = new string[ListTask.Items.Count];

            for( int i = 0; i < ListTask.Items.Count; i++)
                tasks[i] = (ListTask.Items[i] as CustomItemList).Task;

            object[] data = new object[2];
            data[0] = isConnected;
            data[1] = tasks;
           


            Frame.Navigate(typeof(PageConfigTomato), data);
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            if (TxtTask.Text != "")
            {
                CustomItemList item = new CustomItemList(TxtTask.Text) { IsEnabled = false };
                ListTask.Items.Add(item);
                TxtTask.Text = "";
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            { 
                object[] data = (object[])e.Parameter;
                isConnected = (bool)data[0];
                string[] task = (string[])data[1];

                foreach(string s in task)
                {
                    CustomItemList item = new CustomItemList(s) { IsEnabled = false };
                    ListTask.Items.Add(item);
                }

            }
            catch (InvalidCastException ex)
            {
                isConnected = (bool)e.Parameter;
            }
        }

        private void TxtTask_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
                BtAdd_Click(null, null);
        }
    }
}
