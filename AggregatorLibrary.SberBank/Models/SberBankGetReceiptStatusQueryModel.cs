namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankGetReceiptStatusQueryModel : SberBankBaseQueryModel
    {
        public string orderId { get; set; }

        public string orderNumber { get; set; }

        public string uuid { get; set; }

        public string language { get; set; }
    }
}
