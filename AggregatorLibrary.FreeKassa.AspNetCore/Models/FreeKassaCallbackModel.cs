using Newtonsoft.Json;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AggregatorLibrary.FreeKassa.AspNetCore.Models
{
    public class FreeKassaCallbackModel
    {
        /// <summary>
        /// ID магазина
        /// </summary>
        [JsonProperty("MERCHANT_ID")]
        public int MERCHANT_ID { get; set; }

        /// <summary>
        /// Сумма заказа (в валюте магазина)
        /// </summary>
        [JsonProperty("AMOUNT")]
        public double AMOUNT { get; set; }

        /// <summary>
        /// Номер операции FreeKassa
        /// </summary>
        [JsonProperty("intid")]
        public int intid { get; set; }

        /// <summary>
        /// Номер заказа в магазине
        /// </summary>
        [JsonProperty("MERCHANT_ORDER_ID")]
        public int MERCHANT_ORDER_ID { get; set; }

        /// <summary>
        /// Email плательщика (если указан)
        /// </summary>
        [JsonProperty("P_EMAIL")]
        public string P_EMAIL { get; set; }

        /// <summary>
        /// Телефон плательщика (если указан)
        /// </summary>
        [JsonProperty("P_PHONE")]
        public string P_PHONE { get; set; }

        /// <summary>
        /// ID электронной валюты, который был оплачен заказ 
        /// </summary>
        [JsonProperty("CUR_ID")]
        public double CUR_ID { get; set; }

        /// <summary>
        /// Подпись 
        /// </summary>
        [JsonProperty("SIGN")]
        public string SIGN { get; set; }


        public bool CheckSignKey(string secret2)
            => GenerateSignKey(MERCHANT_ID, AMOUNT, secret2, MERCHANT_ORDER_ID)
            .Equals(SIGN, System.StringComparison.InvariantCultureIgnoreCase);

        private static string GenerateSignKey(int merchantId, double amount, string secret, int orderId)
            => GenerateHash(merchantId, amount, secret, orderId);

        private static string GenerateHash(params object[] values)
        {
            var data = Encoding.ASCII.GetBytes(string.Join(":", values));

            byte[] hash;

            using (var md5 = MD5.Create())
                hash = md5.ComputeHash(data);

            return string.Join("", hash.Select(x => x.ToString("x2"))).ToLower();
        }
    }
}
