using AggregatorLibrary.Tinkoff.Interfaces;
using System.Collections.Generic;

namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/init-request/
    /// </summary>
    public class InitRequestModel : TokenRequestInterface
    {
        public string TerminalKey { get; set; }

        public long? Amount { get; set; }

        public string OrderId { get; set; }

        public string IP { get; set; }

        public string Description { get; set; }

        public string Token { get; set; }

        public string Language { get; set; }

        /// <summary>
        /// Идентификатор родительского платежа (Для регистрации автоплатежа) Y/N
        /// </summary>
        public string Recurrent { get; set; }

        public string CustomerKey { get; set; }

        /// <summary>
        /// Cрок жизни ссылки, Временная метка по стандарту ISO8601 в формате yyyy-MM-ddThh:mm:sszzz
        /// </summary>
        public string RedirectDueDate { get; set; }

        public string NotificationURL { get; set; }

        public string SuccessURL { get; set; }

        public string FailURL { get; set; }

        /// <summary>
        /// Тип оплаты: O — одностадийная / T — двухстадийная
        /// </summary>
        public string PayType { get; set; }

        public ReceiptModel Receipt { get; set; }

        public Dictionary<string, string> DATA { get; set; }
    }
}
