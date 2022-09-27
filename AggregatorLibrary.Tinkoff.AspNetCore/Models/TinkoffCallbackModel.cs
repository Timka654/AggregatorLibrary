using AggregatorLibrary.Tinkoff.Interfaces;
using System.Collections.Generic;

namespace AggregatorLibrary.Tinkoff.AspNetCore.Models
{
    public class TinkoffCallbackModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public string OrderId { get; set; }

        public bool Success { get; set; }

        public string Status { get; set; }

        public long PaymentId { get; set; }

        public string ErrorCode { get; set; }

        public long Amount { get; set; }

        public long? RebillId { get; set; }

        public int CardId { get; set; }

        public string Pan { get; set; }

        public string ExpDate { get; set; }

        public string Token { get; set; }

        public Dictionary<string, string> DATA { get; set; }

        public bool VerifyPayment(TinkoffRussia tinkoffApi)
        {
            if (tinkoffApi.TerminalKey != TerminalKey)
                return false;

            var hash = TinkoffRussia.GetHash(tinkoffApi, this);

            return hash == Token;
        }
    }
}
