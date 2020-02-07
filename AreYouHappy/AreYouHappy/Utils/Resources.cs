using System;
using System.Collections.Generic;
using System.Text;
using AreYouHappy.Models;

namespace AreYouHappy.Utils
{
    public static class Resources
    {
        public static class MockedQuestions
        {
            public static Question FirstMockedQuestion = new Question
            {
                Id = "111111", QuestionText = "Do you really have nothing to be grateful for?",
                Description =
                    "Water? Food? Home? Car? Money in your pocket? Is it so obvious, that you have some of those things? What are you looking for? The perfect life? Focus on your life!",
                ProTipText = "Try not to drink anything during the whole day. In the evening, drink glass of water."
            };

            public static Question SecondMockedQuestion = new Question
            {
                Id = "22222222", QuestionText = "Do you have anyone to care about?",
                Description =
                    "Do you? Do you have someone you care about? Or, is out there somebody, who cares about you? Isn't it wonderful?",
                ProTipText =
                    "Find somebody you care about, and tell him/her, that you do. That you care about that person."
            };

            public static Question ThirdMockedQuestion = new Question
            {
                Id = "33333333", QuestionText = "Do you have anything to be proud of?",
                Description = "Seriously, do you have anything like this?",
                ProTipText = "Thin about last years of your life. What did you achieved?"
            };

        }
    }
}
