using AreYouHappy.Models;

namespace AreYouHappy.ViewModels
{
    public class QuestionPageViewModel : BaseViewModel
    {
        public Question Question { get; set; }
        public QuestionPageViewModel(Question question = null)
        {
            Title = question?.QuestionText;
            Question = question;
            
        }
    }
}
