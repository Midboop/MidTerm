using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MidTerm
{
    [Activity(Label = "Zest", Theme = "@style/AppTheme", MainLauncher = true)]
    public class IntroActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Intro);

            Button recipe = FindViewById<Button>(Resource.Id.recipe);
            recipe.Click += delegate
            {

                StartActivity(typeof(RecipeActivity));
            };
            // Create your application here
        }
    }
}