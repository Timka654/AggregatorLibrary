using AggregatorLibrary.SberBank.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AggregatorLibrary.SberBank
{
    public class SberBankRussia
    {
        #region consts

        protected const string TestDomainApiUrl = "3dsec.sberbank.ru";
        protected const string WorkingDomainApiUrl = "securepayments.sberbank.ru";

        protected const string PaymentUrlSufix = "/payment/rest/";



        protected const string RegisterUrl = PaymentUrlSufix + "register.do";

        protected const string RegisterPreAuthUrl = PaymentUrlSufix + "registerPreAuth.do";

        protected const string DepositUrl = PaymentUrlSufix + "deposit.do";

        protected const string ReverseUrl = PaymentUrlSufix + "reverse.do";

        protected const string RefundUrl = PaymentUrlSufix + "refund.do";

        protected const string GetOrderStatusExtendedUrl = PaymentUrlSufix + "getOrderStatusExtended.do";

        protected const string VerifyEnrollmentUrl = PaymentUrlSufix + "verifyEnrollment.do";

        protected const string DeclineUrl = PaymentUrlSufix + "decline.do";

        protected const string GetReceiptStatusUrl = PaymentUrlSufix + "getReceiptStatus.do";

        protected const string UnBindCardUrl = PaymentUrlSufix + "unBindCard.do";

        protected const string BindCardUrl = PaymentUrlSufix + "bindCard.do";

        protected const string GetBindingsUrl = PaymentUrlSufix + "getBindings.do";

        protected const string GetBindingsByCardOrIdUrl = PaymentUrlSufix + "getBindingsByCardOrId.do";

        protected const string ExtendBindingUrl = PaymentUrlSufix + "extendBinding.do";

        #endregion

        public static async Task<RequestResult<SberBankRegisterResultModel>> Register(SberBankRegisterQueryModel query, X509Certificate2 cert = null)
        {
            return await SendQuery<SberBankRegisterQueryModel, SberBankRegisterResultModel>(GetDefaultBuilder(RegisterUrl), query, cert);
        }

        public static async Task<RequestResult<SberBankRegisterPreAuthResultModel>> RegisterPreAuth(SberBankRegisterPreAuthQueryModel query, X509Certificate2 cert = null)
        {
            return await SendQuery<SberBankRegisterPreAuthQueryModel, SberBankRegisterPreAuthResultModel>(GetDefaultBuilder(RegisterPreAuthUrl), query, cert);
        }

        public static async Task<RequestResult<SberBankDepositResultModel>> Deposit(SberBankDepositQueryModel query)
        {
            return await SendQuery<SberBankDepositQueryModel, SberBankDepositResultModel>(GetDefaultBuilder(DepositUrl), query);
        }

        public static async Task<RequestResult<SberBankReverseResultModel>> Reverse(SberBankReverseQueryModel query)
        {
            return await SendQuery<SberBankReverseQueryModel, SberBankReverseResultModel>(GetDefaultBuilder(ReverseUrl), query);
        }

        public static async Task<RequestResult<SberBankRefundResultModel>> Refund(SberBankRefundQueryModel query)
        {
            return await SendQuery<SberBankRefundQueryModel, SberBankRefundResultModel>(GetDefaultBuilder(RefundUrl), query);
        }

        public static async Task<RequestResult<SberBankGetOrderStatusExtendedResultModel>> GetOrderStatusExtended(SberBankGetOrderStatusExtendedQueryModel query)
        {
            return await SendQuery<SberBankGetOrderStatusExtendedQueryModel, SberBankGetOrderStatusExtendedResultModel>(GetDefaultBuilder(GetOrderStatusExtendedUrl), query);
        }

        public static async Task<RequestResult<SberBankVerifyEnrollmentResultModel>> VerifyEnrollment(SberBankVerifyEnrollmentQueryModel query)
        {
            return await SendQuery<SberBankVerifyEnrollmentQueryModel, SberBankVerifyEnrollmentResultModel>(GetDefaultBuilder(VerifyEnrollmentUrl), query);
        }

        public static async Task<RequestResult<SberBankDeclineResultModel>> Decline(SberBankDeclineQueryModel query)
        {
            return await SendQuery<SberBankDeclineQueryModel, SberBankDeclineResultModel>(GetDefaultBuilder(DeclineUrl), query);
        }

        public static async Task<RequestResult<SberBankGetReceiptStatusResultModel>> GetReceiptStatus(SberBankGetReceiptStatusQueryModel query)
        {
            return await SendQuery<SberBankGetReceiptStatusQueryModel, SberBankGetReceiptStatusResultModel>(GetDefaultBuilder(GetReceiptStatusUrl), query);
        }

        public static async Task<RequestResult<SberBankUnBindCardResultModel>> UnBindCard(SberBankUnBindCardQueryModel query)
        {
            return await SendQuery<SberBankUnBindCardQueryModel, SberBankUnBindCardResultModel>(GetDefaultBuilder(UnBindCardUrl), query);
        }

        public static async Task<RequestResult<SberBankBindCardResultModel>> BindCard(SberBankBindCardQueryModel query)
        {
            return await SendQuery<SberBankBindCardQueryModel, SberBankBindCardResultModel>(GetDefaultBuilder(BindCardUrl), query);
        }

        public static async Task<RequestResult<SberBankGetBindingsResultModel>> GetBindings(SberBankGetBindingsQueryModel query)
        {
            return await SendQuery<SberBankGetBindingsQueryModel, SberBankGetBindingsResultModel>(GetDefaultBuilder(GetBindingsUrl), query);
        }

        public static async Task<RequestResult<SberBankGetBindingsByCardOrIdResultModel>> GetBindingsByCardOrId(SberBankGetBindingsByCardOrIdQueryModel query)
        {
            return await SendQuery<SberBankGetBindingsByCardOrIdQueryModel, SberBankGetBindingsByCardOrIdResultModel>(GetDefaultBuilder(GetBindingsByCardOrIdUrl), query);
        }

        public static async Task<RequestResult<SberBankExtendBindingResultModel>> ExtendBinding(SberBankExtendBindingQueryModel query)
        {
            return await SendQuery<SberBankExtendBindingQueryModel, SberBankExtendBindingResultModel>(GetDefaultBuilder(ExtendBindingUrl), query);
        }

        #region Web

        public static bool TestMode { get; set; } = false;

        protected static UriBuilder GetDefaultBuilder(string path = null) => new UriBuilder("https", TestMode ? TestDomainApiUrl : WorkingDomainApiUrl, 443, path);

        protected static async Task<RequestResult<TResult>> SendQuery<TValue, TResult>(UriBuilder uri, TValue data, X509Certificate2 cert = null)
        {

            return await SendQuery<TResult>(uri, new FormUrlEncodedContent(ToKeyValue(data)), cert);
        }

        protected static async Task<RequestResult<TResult>> SendQuery<TResult>(UriBuilder uri, object data, X509Certificate2 cert = null)
        {
            return await SendQuery<TResult>(uri, new FormUrlEncodedContent(ToKeyValue(data)), cert);
        }

        protected static async Task<RequestResult<TResult>> SendQuery<TResult>(UriBuilder uri, FormUrlEncodedContent data, X509Certificate2 cert = null)
        {
            Console.WriteLine($"sb query url {uri.ToString()} {await data.ReadAsStringAsync()}");

            var _clientHandler = new HttpClientHandler();

            if (cert != null)
                _clientHandler.ClientCertificates.Add(cert);

            _clientHandler.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;


            HttpResponseMessage result;

            using (HttpClient c = new HttpClient(_clientHandler))
                result = await c.PostAsync(uri.ToString(), data);

            var r = new RequestResult<TResult>();

            r.IsSuccess = result.IsSuccessStatusCode;
            r.StatusCode = result.StatusCode;
            r.Data = JsonConvert.DeserializeObject<TResult>(await result.Content.ReadAsStringAsync());
            return r;
        }

        public static IDictionary<string, string> ToKeyValue(object metaToken)
        {
            if (metaToken == null)
            {
                return null;
            }

            JToken token = metaToken as JToken;
            if (token == null)
            {
                return ToKeyValue(JObject.FromObject(metaToken));
            }

            if (token.HasValues)
            {
                var contentData = new Dictionary<string, string>();
                foreach (var child in token.Children().ToList())
                {
                    var childContent = ToKeyValue(child);
                    if (childContent != null)
                    {
                        contentData = contentData.Concat(childContent)
                            .ToDictionary(k => NormalizeKey(k.Key), v => v.Value);
                    }
                }

                return contentData;
            }

            var jValue = token as JValue;
            if (jValue?.Value == null)
            {
                return null;
            }

            var value = jValue?.Type == JTokenType.Date ?
                jValue?.ToString("o", CultureInfo.InvariantCulture) :
                jValue?.ToString(CultureInfo.InvariantCulture);

            return new Dictionary<string, string> { { NormalizeKey(token.Path), value } };
        }

        protected static string NormalizeKey(string key)
        {
            return new string(key.Skip(1).Prepend(char.ToLower(key[0])).ToArray());
        }

        public class RequestResult<TData>
        {
            public bool IsSuccess { get; set; }

            public HttpStatusCode StatusCode { get; set; }

            public TData Data { get; set; }
        }

        #endregion
    }
}
