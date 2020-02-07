using System;
using AreYouHappy.Models;
using AreYouHappy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreYouHappy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionPage : ContentPage
	{
	    private QuestionPageViewModel _viewModel;

		public QuestionPage (QuestionPageViewModel questionPageViewModel)
		{
			InitializeComponent ();
	        BindingContext = this._viewModel = questionPageViewModel;

		    if (string.IsNullOrEmpty(questionPageViewModel.Question.ProTipText))
		        ProTipButton.IsVisible = false;
		}

	    public QuestionPage()
	    {
	        InitializeComponent();
            
	        _viewModel = new QuestionPageViewModel();
	        BindingContext = _viewModel;
	    }

	    async void Cancel_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync();
        }

	    private void ProTipButton_Clicked(object sender, EventArgs e)
	    {
	        ProTipLabel.IsVisible = true;
            
	    }

	    async void YesButton_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new NavigationPage(new CongratsPage()), true);
        }

	    async void NoButton_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync(true);
	    }
	}

}