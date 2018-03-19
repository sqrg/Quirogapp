using MvvmCross.ViewModels;
using Quirogapp.Core.ViewModels;

namespace Quirogapp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
