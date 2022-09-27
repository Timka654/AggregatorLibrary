namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://www.tinkoff.ru/kassa/develop/api/payments/init-request/
    /// </summary>
    public class ReceiptModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string EmailCompany { get; set; }
        /// <summary>
        /// Система налогообложения:
        ///        osn — общая
        ///        usn_income — упрощенная(доходы)
        ///        usn_income_outcome — упрощенная(доходы минус расходы)
        ///        patent — патентная
        ///        envd — единый налог на вмененный доход
        ///        esn — единый сельскохозяйственный налог
        /// </summary>
        public string Taxation { get; set; }

        public ReceiptItemsModel[] Items { get; set; }

        public ReceiptPaymentsModel[] Payments { get; set; }
    }
}
