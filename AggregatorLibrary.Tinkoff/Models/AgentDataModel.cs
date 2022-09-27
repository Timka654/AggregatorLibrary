namespace AggregatorLibrary.Tinkoff.Models
{
    public class AgentDataModel
    {
        /// <summary>
        /// Признак агента. Возможные значения:
        ///        bank_paying_agent – банковский платежный агент
        ///        bank_paying_subagent – банковский платежный субагент
        ///        paying_agent – платежный агент
        ///        paying_subagent – платежный субагент
        ///        attorney – поверенный
        ///        commission_agent – комиссионер
        ///        another – другой тип агента
        /// </summary>
        public string AgentSign { get; set; }

        public string OperationName { get; set; }

        public string[] Phones { get; set; }

        public string[] ReceiverPhones { get; set; }

        public string[] TransferPhones { get; set; }

        public string OperatorName { get; set; }

        public string OperatorAddress { get; set; }

        public string OperatorInn { get; set; }
    }
}
