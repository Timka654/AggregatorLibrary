using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/SendClosingReceipt-request/
    /// </summary>
    public class SendClosingReceiptRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public long PaymentId { get; set; }

        public string Token { get; set; }

        public ReceiptModel Receipt { get; set; }
    }
}
