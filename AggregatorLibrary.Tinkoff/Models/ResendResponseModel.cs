namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/resend-response/
    /// </summary>
    public class ResendResponseModel
    {
        public string TerminalKey { get; set; }

        public int Count { get; set; }

        public bool Success { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}
