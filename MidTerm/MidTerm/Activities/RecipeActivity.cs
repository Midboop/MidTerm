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
    public class RecipeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Sets the Recipes layout
            SetContentView(Resource.Layout.Recipes);
            // Create your application here

            // Allows for changing screen to recipe tab
            Button recipe = FindViewById<Button>(Resource.Id.recipe);
            recipe.Click += delegate
            {

                StartActivity(typeof(RecipeActivity));
            };
            // Changes to the Pantry tab
            Button pantry = FindViewById<Button>(Resource.Id.pantry);
            pantry.Click += delegate
            {
                StartActivity(typeof(PantryActivity));
            };
            // Changes to the Calculator tab
            Button calc = FindViewById<Button>(Resource.Id.calculator);
            calc.Click += delegate
            {
                StartActivity(typeof(CalculatorActivity1));
            };
        }
    }
}