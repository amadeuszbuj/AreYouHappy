using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreYouHappy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

	    async void YesButton_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new CongratsPage()), true);
	    }

	    async void NoButton_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new InformationPage()), true);
	    }
	}
}