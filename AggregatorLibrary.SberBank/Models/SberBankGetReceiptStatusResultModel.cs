namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankGetReceiptStatusResultModel : SberBankBaseResultModel
    {
        public string orderNumber { get; set; }

        public string orderId { get; set; }

        public string daemonСode { get; set; }

        public string ecr_registration_number { get; set; }

        public SberBankReceiptModel receipt { get; set; }
    }
}
