namespace AggregatorLibrary.Tinkoff.Models
{
    public class ReceiptPaymentsModel
    {
        public int? Cash { get; set; }

        public int Electronic { get; set; }

        public int? AdvancePayment { get; set; }

        public int? Credit { get; set; }

        public int? Provision { get; set; }
    }
}
