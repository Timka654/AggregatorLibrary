namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankDepositQueryModel : SberBankBaseQueryModel
    {
        public string OrderId { get; set; }

        public int Amount { get; set; }
    }
}
