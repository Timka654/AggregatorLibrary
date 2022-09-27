namespace AggregatorLibrary.Tinkoff.Models
{
    public class ChargeResponseModel
    {
        public string TerminalKey { get; set; }

        public long Amount { get; set; }

        public string OrderId { get; set; }

        public bool Success { get; set; }

        public string Status { get; set; }

        public long PaymentId { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}
