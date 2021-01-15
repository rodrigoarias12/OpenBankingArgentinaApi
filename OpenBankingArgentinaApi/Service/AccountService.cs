
using MongoDB.Driver;
using OpenBankingArgentinaAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpenBankingArgentinaAPI.Services
{
    public class AccountService
    {
        private readonly IMongoCollection<Account> _books;

        public AccountService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Account>("accounts");
        }

        public List<Account> Get() =>
            _books.Find(Account => true).ToList();


    }
}