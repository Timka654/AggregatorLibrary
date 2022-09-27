namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankGetOrderStatusExtendedQueryModel : SberBankBaseQueryModel
    {
        public string Token { get; set; }

        public string OrderId { get; set; }

        public string OrderNumber { get; set; }

        public string Language { get; set; }
    }
}
