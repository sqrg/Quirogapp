using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross;
using MvvmCross.Forms.Platform.Android.Views;
using MvvmCross.ViewModels;
using Quirogapp.Core.ViewModels;

namespace Quirogapp.Droid
{
    [Activity(
        Label = "Quirogapp",
        Icon = "@drawable/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
        )]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();
            InitializeForms(bundle);
        }
    }
}

