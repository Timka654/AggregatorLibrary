namespace AggregatorLibrary.Tinkoff.Models
{
    public class ReceiptItemsModel
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public long Amount { get; set; }

        public int Price { get; set; }

        /// <summary>
        /// Признак способа расчета:
        ///        full_payment — полный расчет (По умолчанию)
        ///        full_prepayment — предоплата 100%
        ///        prepayment — предоплата
        ///        advance — аванс
        ///        partial_payment — частичный расчет и кредит
        ///        credit — передача в кредит
        ///        credit_payment — оплата кредита
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Признак предмета расчета:
        ///        commodity — товар (По умолчанию)
        ///        excise — подакцизный товар
        ///        job — работа
        ///        service — услуга
        ///        gambling_bet — ставка азартной игры
        ///        gambling_prize — выигрыш азартной игры
        ///        lottery — лотерейный билет
        ///        lottery_prize — выигрыш лотереи
        ///        intellectual_activity — предоставление результатов интеллектуальной деятельности
        ///        payment — платеж
        ///        agent_commission — агентское вознаграждение
        ///        composite — составной предмет расчета
        ///        another — иной предмет расчета
        /// </summary>
        public string PaymentObject { get; set; }

        /// <summary>
        /// Ставка НДС:
        ///        none — без НДС
        ///        vat0 — 0%
        ///        vat10 — 10%
        ///        vat20 — 20%
        ///        vat110 — 10/110
        ///        vat120 — 20/120
        /// </summary>
        public string Tax { get; set; }

        public string Ean13 { get; set; }

        public AgentDataModel AgentData { get; set; }

        public SupplierInfoModel SupplierInfo { get; set; }
    }
}
