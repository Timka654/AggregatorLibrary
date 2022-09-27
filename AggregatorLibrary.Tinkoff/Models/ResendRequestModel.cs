using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/resend-request/
    /// </summary>
    public class ResendRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        /// <summary>
        /// https://oplata.tinkoff.ru/develop/api/request-sign/
        /// </summary>
        public string Token { get; set; }

    }
}
