using System;
using System.Collections.Generic;
using System.Text;

namespace AreYouHappy.Models
{
    public class Question
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }
        public string Description { get; set; }
        public string FirstButtonText { get; set; }
        public string SeconButtonText { get; set; }
        public string ProTipButtonText { get; set; }
    }
}
