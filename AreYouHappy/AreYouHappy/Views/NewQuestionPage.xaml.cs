using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AreYouHappy.Models;

namespace AreYouHappy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewQuestionPage : ContentPage
    {
        public Question Question { get; set; }

        public NewQuestionPage()
        {
            InitializeComponent();

            Question = new Question()
            {
                Id = Guid.NewGuid().ToString(),
                QuestionText = "Question text",
                Description = "This is a question description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Question);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}