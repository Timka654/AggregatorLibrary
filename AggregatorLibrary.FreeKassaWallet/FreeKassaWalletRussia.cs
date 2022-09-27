using AggregatorLibrary.FreeKassaWallet.Models;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace AggregatorLibrary.FreeKassaWallet
{
    public class FreeKassaWalletRussia
    {
        private const string FreeKassaUrl = "https://www.fkwallet.ru/api_v1.php";

        private static readonly CultureInfo _cultureInfo = new CultureInfo("en-US");

        public static FreeKassaWalletPaymentResultModel Payment(FreeKassaWalletPaymentFormDataModel p, string apiKey)
        {
            FreeKassaWalletPaymentResultModel r = new FreeKassaWalletPaymentResultModel()
            {
                Status = "error",
                Desc = "Service unavailible"
            };
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                    string data = $"wallet_id={p.WalletId}";
                    data += $"&action=cashout";
                    data += $"&purse={p.Purse}";
                    data += $"&amount={p.Amount.ToString("0.00", _cultureInfo)}";
                    if (!string.IsNullOrEmpty(p.Desc))
                        data += $"&desc={p.Desc}";
                    data += $"&currency={p.Currency}";
                    using (MD5 m = MD5.Create())
                    {
                        data += $"&sign={string.Join("", m.ComputeHash(Encoding.ASCII.GetBytes($"{p.WalletId}{p.Currency}{p.Amount.ToString("0.00", _cultureInfo)}{p.Purse}{apiKey}")).Select(x => x.ToString("x2"))).ToLower()}";
                    }

                    var result = wc.UploadString(FreeKassaUrl, "POST", data);

                    r = JsonConvert.DeserializeObject<FreeKassaWalletPaymentResultModel>(result);

                    r.Desc = r.Desc.Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return r;
        }
    }
}
