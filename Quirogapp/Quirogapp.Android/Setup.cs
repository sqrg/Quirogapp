using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using MvvmCross.ViewModels;
using Quirogapp.UI;
using Xamarin.Forms;

namespace Quirogapp.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        // Note this is slightly different from the iOS and UWP projects in that the GetViewAssemblies
        // method excludes the assembly for the Android head project. This is to avoid the MainActivity
        // being added as a view, that based on our naming convention would match with MainViewModel
        // giving a duplicate when attempting to resolve the View that should be rendered
        // Ver: https://nicksnettravels.builttoroam.com/post/2017/12/27/Getting-Started-MvvmCross-with-Xamarin-Forms-(Part-2).aspx
        protected override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies()
                .Union(new[] {typeof(FormsApp).GetTypeInfo().Assembly})
                .Except(new[] {this.GetType().Assembly}));
        }

        protected override Application CreateFormsApplication() => new FormsApp();

        protected override IMvxApplication CreateApp() => new Core.App();
    }
}