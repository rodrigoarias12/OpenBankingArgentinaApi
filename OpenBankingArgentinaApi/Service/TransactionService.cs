
using MongoDB.Driver;
using OpenBankingArgentinaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpenBankingArgentinaApi.Services
{
    public class TransactionService
    {
        private readonly IMongoCollection<Transaction> _books;

        public TransactionService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Transaction>("Transaction");
        }

        public List<Transaction> Get() =>
            _books.Find(book => true).ToList();

        public Transaction Get(string id) =>
            _books.Find<Transaction>(book => book.id == id).FirstOrDefault();

    }
}