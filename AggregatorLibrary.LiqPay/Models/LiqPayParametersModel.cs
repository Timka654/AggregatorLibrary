using AggregatorLibrary.Currency;
using AggregatorLibrary.LiqPay.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AggregatorLibrary.LiqPay.Models
{
    public class LiqPayParametersModel
    {
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; } = 3;

        [JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayActionsEnum Action { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ISO_4217CurrencyTypeEnum Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; } = "empty";

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("receiver_email")]
        public string Email { get; set; }

        [JsonIgnore]
        public string PrivateKey { get; set; }
    }
}
