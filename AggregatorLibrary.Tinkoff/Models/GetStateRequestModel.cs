using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/getstate-request/
    /// </summary>
    public class GetStateRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public long PaymentId { get; set; }

        public string IP { get; set; }

        /// <summary>
        /// https://oplata.tinkoff.ru/develop/api/request-sign/
        /// </summary>
        public string Token { get; set; }
    }
}
