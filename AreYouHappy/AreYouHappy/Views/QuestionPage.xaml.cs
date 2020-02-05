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
	    }

	    public QuestionPage()
	    {
	        InitializeComponent();

	        var question = new Question
	        {
	            Id = Guid.NewGuid().ToString(),

	        };

	        _viewModel = new QuestionPageViewModel();
	        BindingContext = _viewModel;
	    }

	    async void Cancel_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync();
        }
	}

}