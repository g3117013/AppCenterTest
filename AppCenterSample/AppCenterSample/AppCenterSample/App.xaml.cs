using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AppCenterSample
{
    public partial class App : Application
    {
        const string uwpKey = "uwpKe056830d8-fa36-4525-9f19-caa861ca8fb8";
        const string iosKey = "c1100290-7584-4db6-93e6-4256218c741a";
        const string androidKey = "b5aea107-2850-4b37-9235-a554405ebf04";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start($"uwp={uwpKey};android={androidKey};ios={iosKey};", 
                            typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
