using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class TransactionInfo
    {
        [JsonProperty("fullName", Required = Required.DisallowNull)]
        public string FullName { get; set; }
        [JsonProperty("creditCardNumber", Required = Required.DisallowNull)]
        public string CreditCardNumber { get; set; }
        [JsonProperty("creditCardCompeny", Required = Required.DisallowNull)]
        public string CreditCardCompeny { get; set; }
        [JsonProperty("expirationDate", Required = Required.DisallowNull)]
        public string ExpirationDate { get; set; }
        [JsonProperty("cvv", Required = Required.DisallowNull)]
        public string Cvv { get; set; }
        [JsonProperty("amount", Required = Required.DisallowNull)]
        public float Amount { get; set; }
    }
}
