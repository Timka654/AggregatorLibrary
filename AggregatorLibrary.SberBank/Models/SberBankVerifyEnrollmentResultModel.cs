namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankVerifyEnrollmentResultModel : SberBankBaseResultModel
    {
        public string enrolled { get; set; }

        public string emitterName { get; set; }

        public int emitterCountryCode { get; set; }
    }
}
