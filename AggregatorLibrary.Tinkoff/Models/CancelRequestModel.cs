using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/cancel-request/
    /// </summary>
    public class CancelRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public long PaymentId { get; set; }

        public long Amount { get; set; }

        public string IP { get; set; }

        /// <summary>
        /// https://oplata.tinkoff.ru/develop/api/request-sign/
        /// </summary>
        public string Token { get; set; }

        public ReceiptModel Receipt { get; set; }
    }
}
