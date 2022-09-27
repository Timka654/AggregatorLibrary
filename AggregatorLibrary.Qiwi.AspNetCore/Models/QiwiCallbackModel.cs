using Qiwi.BillPayments.Model;
using System;

namespace AggregatorLibrary.Qiwi.AspNetCore.Models
{
    public class QiwiCallbackModel : Notification
    {
        public object Customer { get; set; }

        public object CustomFields { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime ExpirationDateTime { get; set; }
    }
}
