using AggregatorLibrary.Currency;

namespace AggregatorLibrary.CentralBank.Models
{
    public class CBRDailyValuteModel
    {
        public string Id { get; set; }

        public int NumCode { get => (int)Code; set => Code = (ISO_4217CurrencyTypeEnum)value; }

        public ISO_4217CurrencyTypeEnum Code { get; set; }

        public string CharCode { get; set; }

        public int Nominal { get; set; }

        public string Name { get; set; }

        public double Value { get; set; }
    }
}
