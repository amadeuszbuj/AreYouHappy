using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreYouHappy.Models;

namespace AreYouHappy.Services
{
    public class MockDataStore : IDataStore<Question>
    {
        List<Question> _questions;

        public MockDataStore()
        {
            _questions = new List<Question>();

            var mockItems = new List<Question>
            {
                new Question { Id = Guid.NewGuid().ToString(), QuestionText = "First question", Description="This is an question description." },
                new Question { Id = Guid.NewGuid().ToString(), QuestionText = "Second question", Description="This is an question description." },
                new Question { Id = Guid.NewGuid().ToString(), QuestionText = "Third question", Description="This is an question description." },
               
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
    }
}