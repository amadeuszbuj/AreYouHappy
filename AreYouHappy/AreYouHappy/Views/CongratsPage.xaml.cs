using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreYouHappy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreYouHappy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CongratsPage : ContentPage
	{
//	    private CongratsPageViewModel congratsPageViewModel;

		public CongratsPage ()
		{
			InitializeComponent ();
		    //BindingContext = congratsPageViewModel = new CongratsPageViewModel();
		}

	    async void Cancel_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync(true);
	    }
	}
}