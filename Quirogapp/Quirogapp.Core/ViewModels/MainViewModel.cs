using MvvmCross.ViewModels;

namespace Quirogapp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _bindableText = "I'm bound!";
        public string BindableText
        {
            get
            {
                return _bindableText;
            }
            set
            {
                if (BindableText != value)
                {
                    _bindableText = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
