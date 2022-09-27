using AggregatorLibrary.Tinkoff.Interfaces;

namespace AggregatorLibrary.Tinkoff.Models
{
    public class ChargeRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public string Token { get; set; }

        public long PaymentId { get; set; }

        public long RebillId { get; set; }

        public bool SendEmail { get; set; }

        public string InfoEmail { get; set; }

        public string IP { get; set; }
    }
}
