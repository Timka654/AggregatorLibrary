using Newtonsoft.Json;

namespace AggregatorLibrary.LiqPay.Models
{
    public class LiqPayFormDataModel
    {
        /// <summary>
        /// <input name="data" ...></input>
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// <input name="signature" ...></input>
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
