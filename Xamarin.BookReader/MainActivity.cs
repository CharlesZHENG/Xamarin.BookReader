﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.BookReader
{
    [Activity(Label = "Xamarin.BookReader", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

        }
    }
}

