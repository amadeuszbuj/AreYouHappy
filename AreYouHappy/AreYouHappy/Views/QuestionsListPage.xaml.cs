using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AreYouHappy.Models;
using AreYouHappy.Views;
using AreYouHappy.ViewModels;

namespace AreYouHappy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionsListPage : ContentPage
    {
        QuestionsListViewModel viewModel;

        public QuestionsListPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new QuestionsListViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var question = args.SelectedItem as Question;
            if (question == null)
                return;

            await Navigation.PushModalAsync(new NavigationPage(new QuestionPage(new QuestionPageViewModel(question))), true);

            // Manually deselect item.
            QuestionsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewQuestionPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Questions.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}