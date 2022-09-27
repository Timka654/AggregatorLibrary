namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankSecureAuthInfoModel
    {
        public int Eci { get; set; }

        public SberBankThreeDSInfoModel threeDSInfo { get; set; }
    }
}
