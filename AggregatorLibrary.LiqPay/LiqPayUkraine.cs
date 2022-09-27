using AggregatorLibrary.LiqPay.Enums;
using AggregatorLibrary.LiqPay.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorLibrary.LiqPay
{
    public class LiqPayUkraine
    {
        private static readonly JsonSerializerSettings options = new JsonSerializerSettings()
        {
            Converters = new List<JsonConverter>()
            {
                new StringEnumConverter()
            }
        };
        private const string LiqPayUrl = "https://www.liqpay.ua/api/";

        public static LiqPayFormDataModel GenerateFormData(LiqPayParametersModel payParameters)
        {
            LiqPayFormDataModel result = new LiqPayFormDataModel();

            string json = JsonConvert.SerializeObject(payParameters, options);

            result.Data = Convert.ToBase64String(Encoding.ASCII.GetBytes(json));


            string signString = $"{payParameters.PrivateKey}{result.Data}{payParameters.PrivateKey}";

            byte[] tempSignString = ASCIIEncoding.ASCII.GetBytes(signString);
            string outSignString = "";
            using (SHA1 sha1 = SHA1.Create())
            {
                outSignString = Convert.ToBase64String(sha1.ComputeHash(tempSignString, 0, tempSignString.Length));
            }

            result.Signature = outSignString;

            return result;
        }

        public static async Task<LiqPayBotQueryResultModel> QueryBotAsync(LiqPayParametersModel payParameters)
        {
            payParameters.Action = LiqPayActionsEnum.InvoiceBot;

            var form = GenerateFormData(payParameters);

            var data = form.GetType().GetProperties().Select(x => new { p = x, attr = (JsonPropertyAttribute)x.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault() }).Where(x => x.attr != null).ToList();

            string query = string.Join("&", data.Select((x) => $"{x.attr.PropertyName}={x.p.GetValue(form)}"));

            using (var client = new HttpClient())
            {
                var result = await client.PostAsync($"{LiqPayUrl}request", new StringContent(query));

                using (var responseStream = await result.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    var s = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<LiqPayBotQueryResultModel>(s);
                }
            }
        }

        public static async Task<string> QueryGetFormAsync(LiqPayParametersModel payParameters)
        {
            payParameters.Action = LiqPayActionsEnum.InvoiceBot;

            var form = GenerateFormData(payParameters);

            var data = form.GetType().GetProperties().Select(x => new { p = x, attr = (JsonPropertyAttribute)x.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault() }).Where(x => x.attr != null).ToList();

            string query = string.Join("&", data.Select((x) => $"{x.attr.PropertyName}={x.p.GetValue(form)}"));

            using (var client = new HttpClient())
            {
                var result = await client.PostAsync($"{LiqPayUrl}3/checkout", new StringContent(query));

                using (var responseStream = await result.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
