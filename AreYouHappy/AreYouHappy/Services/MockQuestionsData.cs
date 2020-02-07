using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreYouHappy.Models;
using AreYouHappy.Utils;

namespace AreYouHappy.Services
{
    public class MockQuestionsData : IDataStore<Question>
    {
        List<Question> _questions;

        public MockQuestionsData()
        {
            _questions = new List<Question>();

            var mockItems = new List<Question>
            {
                Resources.MockedQuestions.FirstMockedQuestion,
                Resources.MockedQuestions.SecondMockedQuestion,
                Resources.MockedQuestions.ThirdMockedQuestion,           
            };

            foreach (var question in mockItems)
            {
                _questions.Add(question);
            }
        }

        public async Task<bool> AddItemAsync(Question question)
        {
            _questions.Add(question);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Question question)
        {
            var oldItem = _questions.FirstOrDefault(arg => arg.Id == question.Id);
            _questions.Remove(oldItem);
            _questions.Add(question);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _questions.FirstOrDefault(arg => arg.Id == id);
            _questions.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Question> GetItemAsync(string id)
        {
            return await Task.FromResult(_questions.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Question>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_questions);
        }

        public Task<bool> SaveDataToLocalJson()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoadDataFromLocalJson()
        {
            throw new NotImplementedException();
        }
    }
}