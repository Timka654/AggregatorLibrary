namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankRegisterResultModel : SberBankBaseResultModel
    {
        public string orderId { get; set; }

        public string formUrl { get; set; }

        public string externalParams { get; set; }
    }
}
