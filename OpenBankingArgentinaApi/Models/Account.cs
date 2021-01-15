using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBankingArgentinaApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Owner
    {

        public string id { get; set; }
        public string provider { get; set; }
        public string display_name { get; set; }
    }

    public class Balance
    {
        public string currency { get; set; }
        public string amount { get; set; }
    }

    public class AccountRouting
    {
        public string scheme { get; set; }
        public string address { get; set; }
    }

    public class AccountAttribute
    {
        public string product_code { get; set; }
        public string account_attribute_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string provider { get; set; }
        public string display_name { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string value { get; set; }
        public DateTime date { get; set; }
        public User user { get; set; }
    }

    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string label { get; set; }
        public string number { get; set; }
        //public Dictionary<string,Owner> owners { get; set; }
        public string product_code { get; set; }
        public Balance balance { get; set; }
        public string bank_id { get; set; }
        public List< AccountRouting> account_routings { get; set; }
        public List< AccountAttribute> account_attributes { get; set; }
      //  public List<Tag> tags { get; set; }
    }
}
