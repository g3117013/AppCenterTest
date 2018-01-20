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
        const string uwpKey = "2b977979-ebbc-40f8-b6d2-cddb98312ac1";
        const string iosKey = "233ad039-4e6d-4baf-8824-3845db2f2907";
        const string androidKey = "a981827b-441f-4ab1-990e-e582d18d60bf";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start($"uwp={uwpKe056830d8-fa36-4525-9f19-caa861ca8fb8};android={b5aea107-2850-4b37-9235-a554405ebf04};ios={c1100290-7584-4db6-93e6-4256218c741a};", 
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
