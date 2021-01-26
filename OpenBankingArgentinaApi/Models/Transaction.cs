
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace OpenBankingArgentinaApi.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class ThisAccount
    {
        public string this_id { get; set; }
        public string bank { get; set; }

    }
    public class Counterparty
    {
        public string name { get; set; }

    }
    public class Details
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public DateTime completed { get; set; }
        public string new_balance { get; set; }
        public string value { get; set; }
    }

    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public ThisAccount this_account { get; set; }
        public Counterparty counterparty { get; set; }
        public Details details { get; set; }
    }

    public class Transactions
    {
        public List<Transaction> transactions { get; set; }
    }
}