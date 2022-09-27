using AggregatorLibrary.CentralBank.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace AggregatorLibrary.CentralBank
{
    /// <summary>
    /// Апи для взаимодействия с центральным банком Украины
    /// </summary>
    public class NBU
    {
        public static string ExchangeQueryUrl = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";

        public static NBUExchangeQueryResultModel ExchangeQuery()
        {
            using (WebClient wc = new WebClient())
            {
                var textData = wc.DownloadString(ExchangeQueryUrl);

                var data = JsonConvert.DeserializeObject<List<NBUExchangeRowModel>>(textData);

                return new NBUExchangeQueryResultModel() { Data = data };
            }
        }
    }
}
