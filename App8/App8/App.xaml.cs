using App8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App8
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //MainPage = new App8.HomePage();

            showMessage();
        }

        private void showMessage()
        {
            // Toast button
            Button showToastButton = new Button() { Text = "Show toast", HorizontalOptions = LayoutOptions.Center };
            showToastButton.Clicked += (s, e) =>
            {
                if (Device.OS == TargetPlatform.Android)
                {
                    DependencyService.Get<IAndroidPopUp>().ShowToast("This is a toast");
                }
            };

            // Snackbar button
            Button showSnackbarButton = new Button() { Text = "Show snackbar", HorizontalOptions = LayoutOptions.Center };
            showSnackbarButton.Clicked += (s, e) =>
            {
                if (Device.OS == TargetPlatform.Android)
                {
                    DependencyService.Get<IAndroidPopUp>().ShowSnackbar("This is a snackbar");
                }
            };

            StackLayout mainContent = new StackLayout() { VerticalOptions = LayoutOptions.Center };
            mainContent.Children.Add(showToastButton);
            mainContent.Children.Add(showSnackbarButton);

            MainPage = new ContentPage
            {
                Content = mainContent
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
