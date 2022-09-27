namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankRefundQueryModel : SberBankBaseQueryModel
    {
        public string OrderId { get; set; }

        public int Amount { get; set; }

        public string JsonParams { get; set; }
    }
}
