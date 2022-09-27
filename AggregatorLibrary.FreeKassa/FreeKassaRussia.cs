using AggregatorLibrary.FreeKassa.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AggregatorLibrary.FreeKassa
{
    public class FreeKassaRussia
    {
        private const string DomainUrl = "http://www.free-kassa.ru";

        /// <summary>
        /// Вывод для подключенных кошельков в личном кабинете
        /// </summary>
        /// <param name="p"></param>
        /// <param name="currency"></param>
        /// <param name="secret2"></param>
        /// <returns></returns>
        public static string GeneratePaymentLink(FreeKassaPaymentParametersModel p, string currency, string secret2)
        {
            var s = GenerateHash(p.MerchantId, secret2);

            return $"{DomainUrl}/api.php?currency={currency}&merchant_id={p.MerchantId}&s={s}&action=payment&amount={p.Amount}";
        }

        public static string GenerateUrl(FreeKassaParametersModel p, string secret)
        {
            p.SignKey = GenerateSignKey(p.MerchantId, p.Amount, secret, p.OrderId);

            return $"{DomainUrl}/merchant/cash.php?m={p.MerchantId}&oa={p.Amount}&o={p.OrderId}&s={p.SignKey}";
        }

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
