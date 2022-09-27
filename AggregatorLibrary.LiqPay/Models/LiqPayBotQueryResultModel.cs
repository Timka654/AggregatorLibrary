using Newtonsoft.Json;

namespace AggregatorLibrary.LiqPay.Models
{
    public class LiqPayBotQueryResultModel
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("bot_name")]
        public string BotName { get; set; }

        [JsonProperty("bot_url")]
        public string BotUrl { get; set; }

        [JsonProperty("bot_in_contacts")]
        public bool BotInContacts { get; set; }

        [JsonProperty("bot_channel")]
        public string BotChannel { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
