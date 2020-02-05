using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AreYouHappy.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T question);
        Task<bool> UpdateItemAsync(T question);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
