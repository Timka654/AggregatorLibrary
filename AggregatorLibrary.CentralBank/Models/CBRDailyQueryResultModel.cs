using System;
using System.Collections.Generic;

namespace AggregatorLibrary.CentralBank.Models
{
    public class CBRDailyQueryResultModel
    {
        public List<CBRDailyValuteModel> DailyValuteList { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }
    }
}
