namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/confirm-response/
    /// </summary>
    public class ConfirmResponseModel
    {
        public string TerminalKey { get; set; }

        public string OrderId { get; set; }

        public bool Success { get; set; }

        public string Status { get; set; }

        public long PaymentId { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}
