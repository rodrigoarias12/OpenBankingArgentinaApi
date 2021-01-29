
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
namespace OpenBankingArgentinaApi.Models
{
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
        [JsonProperty("id")]
        public string id_this { get; set; }

        [JsonProperty("bank_routing")]
        public Routing BankRouting { get; set; }

        [JsonProperty("account_routings")]
        public Routing[] AccountRoutings { get; set; }
    }
    public partial class OtherAccount
    {
        [JsonProperty("id")]
        public string id_other { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id_type")]
        public string IdType { get; set; }

        [JsonProperty("bank_routing")]
        public Routing BankRouting { get; set; }

        [JsonProperty("account_routings")]
        public Routing[] AccountRoutings { get; set; }
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
        public string Scheme { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
    public partial class Value
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}