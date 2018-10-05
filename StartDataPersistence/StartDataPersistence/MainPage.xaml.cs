using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StartWithDataPersistence
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
                userNickName.Text = Application.Current.Properties["Name"].ToString();

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notificationEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];

            if (Application.Current.Properties.ContainsKey("AirplaneModeEnabled"))
                airplaneModeEnabled.On = (bool)Application.Current.Properties["AirplaneModeEnabled"];

        }

        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = userNickName.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationEnabled.On;
            Application.Current.Properties["AirplaneModeEnabled"] = airplaneModeEnabled.On;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}