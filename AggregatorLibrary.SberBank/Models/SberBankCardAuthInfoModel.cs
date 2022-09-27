namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankCardAuthInfoModel
    {
        public string MaskedPan { get; set; }

        public int Expiration { get; set; }

        public string cardholderName { get; set; }

        public string approvalCode { get; set; }

        public string chargeback { get; set; }

        public string paymentSystem { get; set; }

        public string productCategory { get; set; }

        public string product { get; set; }

        public SberBankSecureAuthInfoModel secureAuthInfo { get; set; }
    }
}
