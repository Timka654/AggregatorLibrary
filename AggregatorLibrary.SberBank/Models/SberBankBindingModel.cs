namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankBindingModel
    {
        public string bindingId { get; set; }

        public string maskedPan { get; set; }

        public int? expiryDate { get; set; }
    }
}
