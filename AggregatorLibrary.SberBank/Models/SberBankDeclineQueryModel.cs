namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankDeclineQueryModel : SberBankBaseQueryModel
    {
        public string merchantLogin { get; set; }

        public string language { get; set; }

        public string orderId { get; set; }

        public string orderNumber { get; set; }
    }
}
