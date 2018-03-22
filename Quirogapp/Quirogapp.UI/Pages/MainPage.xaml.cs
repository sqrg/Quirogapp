using System;
using MvvmCross.Forms.Views;
using Quirogapp.Core.ViewModels;
using Xamarin.Forms;

namespace Quirogapp.UI.Pages
{
	public partial class MainPage : MvxContentPage<MainViewModel>
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    async void Rotate_Clicked(object sender, EventArgs e)
	    {
	        await rotateButton.RotateTo(180);
	        await rotateButton.RotateTo(0, 500, Easing.SpringOut);
        }

	    async void Fade_Clicked(object sender, System.EventArgs e)
	    {
	        await fadeButton.FadeTo(0, 1000, Easing.SinInOut);
	    }
    }
}
