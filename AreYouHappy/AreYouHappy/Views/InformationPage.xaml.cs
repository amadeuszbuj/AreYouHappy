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
	public partial class InformationPage : ContentPage
	{
		public InformationPage ()
		{
			InitializeComponent ();
		}

	    async void ShowQuestListBtn_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new QuestionsListPage(), true);
	    }
	}
}