using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content.PM;
using Android.Views;

namespace TipCalc.Droid
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    //public class MainActivity : AppCompatActivity
    //{
    //    protected override void OnCreate(Bundle savedInstanceState)
    //    {
    //        base.OnCreate(savedInstanceState);

    //        // Set our view from the "main" layout resource
    //        SetContentView(Resource.Layout.activity_main);
    //    }
    //}

    [Activity(
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
        WindowSoftInputMode = SoftInput.AdjustNothing | SoftInput.StateHidden
    )]
    public class MainActivity : Windows.UI.Xaml.ApplicationActivity
    {
    }
}

