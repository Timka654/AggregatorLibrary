namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankExtendBindingQueryModel : SberBankBaseQueryModel
    {
        public string bindingId { get; set; }

        public int newExpiry { get; set; }

        public string language { get; set; }
    }
}
