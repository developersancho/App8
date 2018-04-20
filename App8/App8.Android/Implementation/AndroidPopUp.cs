using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using App8.Interfaces;
using Plugin.CurrentActivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(App8.Droid.Implementation.AndroidPopUp))]
namespace App8.Droid.Implementation
{
    public class AndroidPopUp : IAndroidPopUp
    {
        public void ShowSnackbar(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            // Get root view of current activity
            Android.Views.View activityRootView = activity.FindViewById(Android.Resource.Id.Content);
            Snackbar.Make(activityRootView, message, Snackbar.LengthLong).Show();
        }

        public void ShowToast(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Toast.MakeText(Forms.Context, message, ToastLength.Long).Show();
        }
    }
}