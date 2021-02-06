
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
namespace OpenBankingArgentinaApi.Models
{
    public class ResponseDTOTransactions { 
    public List<Transaction> transactions { get; set; }
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
    public partial class ThisAccount
    {
        public string id_this { get; set; }

        [JsonProperty("bank_routing")]
        public Routing bankRouting { get; set; }

        [JsonProperty("account_routings")]
        public Routing[] accountRoutings { get; set; }
    }
    public partial class OtherAccount
    {
        public string id_other { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("id_type")]
        public string idType { get; set; }

        [JsonProperty("bank_routing")]
        public Routing bankRouting { get; set; }

        [JsonProperty("account_routings")]
        public Routing[] accountRoutings { get; set; }
    }
    public class Details
    {
        public string type { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public DateTime completed { get; set; }
        public Value new_balance { get; set; }
        public Value value { get; set; }
    }
    public partial class Routing
    {
        [JsonProperty("scheme")]
        public string scheme { get; set; }

        [JsonProperty("address")]
        public string address { get; set; }
    }
    public partial class Value
    {
        [JsonProperty("currency")]
        public string currency { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }
    }
}