using AggregatorLibrary.Currency;

namespace AggregatorLibrary.SberBank.Models
{/// <summary>
 /// https://securepayments.sberbank.ru/wiki/doku.php/integration:api:rest:requests:register
 /// </summary>
    public class SberBankRegisterQueryModel : SberBankBaseQueryModel
    {
        public string Token { get; set; } = null;

        public string OrderNumber { get; set; }

        public int Amount { get; set; }

        public ISO_4217CurrencyTypeEnum? Currency { get; set; }

        public string ReturnUrl { get; set; }

        public string FailUrl { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.twoletterisolanguagename?view=net-5.0
        /// </summary>
        public string Language { get; set; }

        public string PageView { get; set; }

        public string ClientId { get; set; }

        public string MerchantLogin { get; set; }

        public string JsonParams { get; set; }

        public int? sessionTimeoutSecs { get; set; }

        public string expirationDate { get; set; }

        public string bindingId { get; set; }

        public string features { get; set; }

        public string email { get; set; }

        public long? phone { get; set; }
    }
}
