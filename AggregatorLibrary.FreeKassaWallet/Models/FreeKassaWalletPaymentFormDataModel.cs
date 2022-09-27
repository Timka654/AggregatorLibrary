namespace AggregatorLibrary.FreeKassaWallet.Models
{
    public class FreeKassaWalletPaymentFormDataModel
    {
        /// <summary>
        /// Идентификатор кассы
        /// </summary>
        public string WalletId { get; set; }

        /// <summary>
        /// Кошелек для вывода
        /// </summary>
        public string Purse { get; set; }

        /// <summary>
        /// Сумма для вывода
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Примечание к платежу
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Метод вывода
        /// </summary>
        public int Currency { get; set; }
    }
}
