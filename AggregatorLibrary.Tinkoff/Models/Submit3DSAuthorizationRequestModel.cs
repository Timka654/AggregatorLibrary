using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/Submit3DSAuthorization-request/
    /// </summary>
    public class Submit3DSAuthorizationRequestModel : TokenRequestInterface
    {
        public string MD { get; set; }

        public string PaRes { get; set; }

        public long PaymentId { get; set; }

        public string Token { get; set; }

        public string TerminalKey { get; set; }
    }
}
