
using MongoDB.Driver;
using OpenBankingArgentinaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpenBankingArgentinaApi.Services
{
    public class TransactionService
    {
        private readonly IMongoCollection<Transaction> _transaction;

        public TransactionService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _transaction = database.GetCollection<Transaction>("Transaction");
        }

        public List<Transaction> Get() =>
            _transaction.Find(book => true).ToList();
            
        public Transaction Get(string id) =>
            _transaction.Find<Transaction>(book => book.Id == id).FirstOrDefault();

    }
}