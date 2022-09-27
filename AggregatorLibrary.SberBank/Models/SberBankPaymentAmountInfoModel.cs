namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankPaymentAmountInfoModel
    {
        public int approvedAmount { get; set; }

        public int depositedAmount { get; set; }

        public int refundedAmount { get; set; }

        public string paymentState { get; set; }

        public int feeAmount { get; set; }
    }
}
