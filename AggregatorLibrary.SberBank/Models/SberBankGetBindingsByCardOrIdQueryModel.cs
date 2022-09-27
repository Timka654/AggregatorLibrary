namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankGetBindingsByCardOrIdQueryModel : SberBankBaseQueryModel
    {
        public string Pan { get; set; }

        public string bindingId { get; set; }

        public bool showExpired { get; set; }
    }
}
