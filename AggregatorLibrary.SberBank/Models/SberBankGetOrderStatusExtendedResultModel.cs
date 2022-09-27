using AggregatorLibrary.Currency;

namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankGetOrderStatusExtendedResultModel : SberBankBaseResultModel
    {
        public string OrderNumber { get; set; }

        public int OrderStatus { get; set; }

        public int ActionCode { get; set; }

        public string ActionCodeDescription { get; set; }

        public int Amount { get; set; }

        public ISO_4217CurrencyTypeEnum? Currency { get; set; }

        public string Date { get; set; }

        public long depositedDate { get; set; }

        public string orderDescription { get; set; }

        public string ip { get; set; }

        public string authRefNum { get; set; }

        public string refundedDate { get; set; }

        public string paymentWay { get; set; }

        public SberBankMerchantOrderParamsModel[] merchantOrderParams { get; set; }

        public SberBankCardAuthInfoModel cardAuthInfo { get; set; }

        public SberBankBindingInfoModel bindingInfo { get; set; }

        public SberBankPaymentAmountInfoModel paymentAmountInfo { get; set; }

        public SberBankBankInfo bankInfo { get; set; }

        public SberBankPayerDataModel payerData { get; set; }

        public SberBankRefundsModel refunds { get; set; }
    }
}
