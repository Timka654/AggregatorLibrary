namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankReverseQueryModel : SberBankBaseQueryModel
    {
        public int Amount { get; set; }

        public string OrderId { get; set; }

        public string JsonParams { get; set; }

        public string Language { get; set; }
    }
}
