using AggregatorLibrary.Tinkoff.Interfaces;
using System.Collections.Generic;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/finishAuthorize-request/#CardData
    /// </summary>
    public class FinishAuthorizeRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public string CardData { get; set; }

        public string EncryptedPaymentData { get; set; }

        public long Amount { get; set; }

        public Dictionary<string, string> DATA { get; set; }

        public string InfoEmail { get; set; }

        public string IP { get; set; }

        public long PaymentId { get; set; }

        public string Phone { get; set; }

        public bool SendEmail { get; set; }

        public string Route { get; set; }

        public string Source { get; set; }

        public string Token { get; set; }
    }
}
