using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/confirm-request/
    /// </summary>
    public class ConfirmRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public long PaymentId { get; set; }

        public long Amount { get; set; }

        public string IP { get; set; }

        public string Token { get; set; }

        public ReceiptModel Receipt { get; set; }
    }
}
