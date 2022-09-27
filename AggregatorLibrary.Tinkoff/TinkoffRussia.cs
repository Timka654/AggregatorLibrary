using AggregatorLibrary.Tinkoff.Interfaces;
using AggregatorLibrary.Tinkoff.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorLibrary.Tinkoff
{
    public class TinkoffRussia
    {
        #region Urls

        public const string HostUrl = "https://securepay.tinkoff.ru/v2/";

        protected const string InitUrl = HostUrl + "Init";

        protected const string ChargeUrl = HostUrl + "Charge";

        protected const string FinishAuthorizeUrl = HostUrl + "FinishAuthorize";

        protected const string ConfirmUrl = HostUrl + "Confirm";

        protected const string CancelUrl = HostUrl + "Cancel";

        protected const string GetStateUrl = HostUrl + "GetState";

        protected const string ResendUrl = HostUrl + "Resend";

        protected const string Submit3DSAuthorizationUrl = HostUrl + "Submit3DSAuthorization";

        protected const string SendClosingReceiptUrl = HostUrl + "SendClosingReceipt";

        #endregion

        #region StatusCodes

        /// <summary>
        /// Создан
        /// </summary>
        public const string PaymentStatusNEW = "NEW";

        /// <summary>
        /// Платежная форма открыта покупателем
        /// </summary>
        public const string PaymentStatusFORMSHOWED = "FORM_SHOWED";

        /// <summary>
        /// Просрочен
        /// </summary>
        public const string PaymentStatusDEADLINEEXPIRED = "DEADLINE_EXPIRED";

        /// <summary>
        /// Отменен
        /// </summary>
        public const string PaymentStatusCANCELED = "CANCELED";

        /// <summary>
        /// Проверка платежных данных (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusPREAUTHORIZING = "PREAUTHORIZING";

        /// <summary>
        /// Резервируется (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusAUTHORIZING = "AUTHORIZING";

        /// <summary>
        /// Зарезервирован
        /// </summary>
        public const string PaymentStatusAUTHORIZED = "AUTHORIZED";

        /// <summary>
        /// Не прошел авторизацию (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusAUTHFAIL = "AUTH_FAIL";

        /// <summary>
        /// Отклонен
        /// </summary>
        public const string PaymentStatusREJECTED = "REJECTED";

        /// <summary>
        /// Проверяется по протоколу 3-D Secure
        /// </summary>
        public const string PaymentStatus3DSCHECKING = "3DS_CHECKING";

        /// <summary>
        /// Проверен по протоколу 3-D Secure (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatus3DSCHECKED = "3DS_CHECKED";

        /// <summary>
        /// Резервирование отменяется (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusREVERSING = "REVERSING";

        /// <summary>
        /// Резервирование отменено частично
        /// </summary>
        public const string PaymentStatusPARTIALREVERSED = "PARTIAL_REVERSED";

        /// <summary>
        /// Резервирование отменено
        /// </summary>
        public const string PaymentStatusREVERSED = "REVERSED";

        /// <summary>
        /// Подтверждается (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusCONFIRMING = "CONFIRMING";

        /// <summary>
        /// Подтвержден
        /// </summary>
        public const string PaymentStatusCONFIRMED = "CONFIRMED";

        /// <summary>
        /// Возвращается (Промежуточное состояние)
        /// </summary>
        public const string PaymentStatusREFUNDING = "REFUNDING";

        /// <summary>
        /// Возвращен частично
        /// </summary>
        public const string PaymentStatusPARTIALREFUNDED = "PARTIAL_REFUNDED";

        /// <summary>
        /// Возвращен полностью
        /// </summary>
        public const string PaymentStatusREFUNDED = "REFUNDED";

        #endregion

        private readonly string terminalKey;
        private readonly string password;

        public string TerminalKey => terminalKey;

        public TinkoffRussia(string terminalKey, string password)
        {
            this.terminalKey = terminalKey;
            this.password = password;
        }

        public async Task<RequestResult<InitResponseModel>> Init(InitRequestModel request)
        {
            var data = await SendQuery<InitRequestModel, InitResponseModel>(InitUrl, request);

            return data;
        }

        public async Task<RequestResult<ChargeResponseModel>> Charge(ChargeRequestModel request)
        {
            var data = await SendQuery<ChargeRequestModel, ChargeResponseModel>(ChargeUrl, request);

            return data;
        }

        public async Task<RequestResult<FinishAuthorizeResponseModel>> FinishAuthorize(FinishAuthorizeRequestModel request)
        {
            var data = await SendQuery<FinishAuthorizeRequestModel, FinishAuthorizeResponseModel>(FinishAuthorizeUrl, request);

            return data;
        }

        public async Task<RequestResult<ConfirmResponseModel>> Confirm(ConfirmRequestModel request)
        {
            var data = await SendQuery<ConfirmRequestModel, ConfirmResponseModel>(ConfirmUrl, request);

            return data;
        }

        public async Task<RequestResult<CancelResponseModel>> Cancel(CancelRequestModel request)
        {
            var data = await SendQuery<CancelRequestModel, CancelResponseModel>(CancelUrl, request);

            return data;
        }

        public async Task<RequestResult<GetStateResponseModel>> GetState(GetStateRequestModel request)
        {
            var data = await SendQuery<GetStateRequestModel, GetStateResponseModel>(GetStateUrl, request);

            return data;
        }

        public async Task<RequestResult<ResendResponseModel>> Resend(ResendRequestModel request)
        {
            var data = await SendQuery<ResendRequestModel, ResendResponseModel>(ResendUrl, request);

            return data;
        }

        public async Task<RequestResult<Submit3DSAuthorizationResponseModel>> Submit3DSAuthorization(Submit3DSAuthorizationRequestModel request)
        {
            var data = await SendQuery<Submit3DSAuthorizationRequestModel, Submit3DSAuthorizationResponseModel>(Submit3DSAuthorizationUrl, request);

            return data;
        }

        public async Task<RequestResult<SendClosingReceiptResponseModel>> SendClosingReceipt(SendClosingReceiptRequestModel request)
        {
            var data = await SendQuery<SendClosingReceiptRequestModel, SendClosingReceiptResponseModel>(SendClosingReceiptUrl, request);

            return data;
        }

        protected async Task<RequestResult<TResult>> SendQuery<TData, TResult>(string uri, TData data)
            where TData : TokenRequestInterface
        {
            var _clientHandler = new HttpClientHandler();
            _clientHandler.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;

            data.TerminalKey = terminalKey;
            data.Token = GetHash(this, data);

            var jsonData = JsonConvert.SerializeObject(data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

            HttpResponseMessage result;

            using (HttpClient c = new HttpClient(_clientHandler))
                result = await c.PostAsync(uri, new StringContent(
                   jsonData,
                   Encoding.UTF8,
                   "application/json"));

            var r = new RequestResult<TResult>(result);

            await r.ReadData();

            return r;
        }

        public static string GenerateToken<T>(TinkoffRussia bank, T data)
            where T : TokenRequestInterface => string.Concat(JToken.FromObject(data).Value<JObject>().Properties().Append(new JProperty("password", bank.password)).Where(x => x.Name.ToLower() != "receipt" && x.Name.ToLower() != "data" && x.Name.ToLower() != "token").OrderBy(x => x.Name).Select(SelectGenerateToken));

        private static string SelectGenerateToken(JProperty p)
        {
            if (p.Value.Type == JTokenType.Boolean)
                return ((string)p.Value).ToLower();
            return p.Value.Value<string>();
        }

        public static string GetHash<T>(TinkoffRussia bank, T data) where T : TokenRequestInterface
        {
            using (var sha = SHA256.Create())
            {
                string line = GenerateToken(bank, data);

                return string.Concat(sha.ComputeHash(Encoding.UTF8.GetBytes(line)).Select(x => x.ToString("x2"))).ToLower();
            }

        }

        public class RequestResult<TData>
        {
            public bool IsSuccess => HttpResponse.IsSuccessStatusCode;

            public HttpStatusCode StatusCode => HttpResponse.StatusCode;

            public TData Data { get; set; }

            public HttpResponseMessage HttpResponse { get; }

            public RequestResult(HttpResponseMessage response)
            {
                HttpResponse = response;
            }

            internal async Task ReadData()
            {
                Data = JsonConvert.DeserializeObject<TData>(await HttpResponse.Content.ReadAsStringAsync());
            }
        }
    }
}
