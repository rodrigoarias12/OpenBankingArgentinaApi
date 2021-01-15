
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace OpenBankingArgentinaApi.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class BankRouting
    {
        public string scheme { get; set; }
        public string address { get; set; }
    }

    public class Holder
    {
        public string name { get; set; }
        public bool is_alias { get; set; }
    }

    public class ThisAccount
    {
        public string id_this { get; set; }
        public BankRouting bank_routing { get; set; }
        public List<AccountRouting> account_routings { get; set; }
        public List<Holder> holders { get; set; }
    }

    public class Holder2
    {
        public string name { get; set; }
        public bool is_alias { get; set; }
    }

    public class OtherAccount
    {
        public string id_other { get; set; }
        public Holder holder { get; set; }
        public BankRouting bank_routing { get; set; }
        public List<AccountRouting> account_routings { get; set; }
    }

    public class NewBalance
    {
        public string currency { get; set; }
        public string amount { get; set; }
    }

    public class Value
    {
        public string currency { get; set; }
        public string amount { get; set; }
    }

    public class Details
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public DateTime completed { get; set; }
        public NewBalance new_balance { get; set; }
        public Value value { get; set; }
    }

    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public ThisAccount this_account { get; set; }
        public OtherAccount other_account { get; set; }
        public Details details { get; set; }
    }

    public class Transactions
    {
        public List<Transaction> transactions { get; set; }
    }
}