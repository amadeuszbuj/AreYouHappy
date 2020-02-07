using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using AreYouHappy.Models;
using AreYouHappy.Views;

namespace AreYouHappy.ViewModels
{
    public class QuestionsListViewModel : BaseViewModel
    {
        public ObservableCollection<Question> Questions { get; set; }
        public Command LoadItemsCommand { get; set; }

        public QuestionsListViewModel()
        {
            Title = "QuestionsList";
            Questions = new ObservableCollection<Question>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewQuestionPage, Question>(this, "AddItem", async (obj, item) =>
            {
                var question = item as Question;
                Questions.Add(question);
                await DataStore.AddItemAsync(question);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Questions.Clear();
                var questions = await DataStore.GetItemsAsync(true);
                foreach (var question in questions)
                {
                    Questions.Add(question);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}