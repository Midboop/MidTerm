using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;



namespace MidTerm
{
    [Activity(Label = "Zest", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

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

       
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}