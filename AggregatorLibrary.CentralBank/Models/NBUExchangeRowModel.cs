using System;

namespace AggregatorLibrary.CentralBank.Models
{
    public class NBUExchangeRowModel
    {
        public int R030 { get; set; }

        public string TXT { get; set; }

        public double Rate { get; set; }

        public string CC { get; set; }

        public DateTime ExchangeDate { get; set; }
    }
}
