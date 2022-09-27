namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/SendClosingReceipt-response/
    /// </summary>
    public class SendClosingReceiptResponseModel
    {
        public bool Success { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }
    }
}
