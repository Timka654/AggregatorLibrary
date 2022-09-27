using Qiwi.BillPayments.Client;
using Qiwi.BillPayments.Model;
using Qiwi.BillPayments.Model.In;
using Qiwi.BillPayments.Model.Out;
using Qiwi.BillPayments.Utils;
using System;

namespace AggregatorLibrary.Qiwi
{
    /// <summary>
    /// Detailed info https://github.com/QIWI-API/bill-payments-dotnet-sdk
    /// </summary>
    public class QiwiRussia
    {
        private BillPaymentsClient client;

        private string publicKey;
        private string secretKey;

        public void CreateClient(string secretKey, string publicKey)
        {
            this.secretKey = secretKey;
            this.publicKey = publicKey;
            client = BillPaymentsClientFactory.Create(
                secretKey: secretKey
            );
        }

        public Uri CreatePaymentFormLink(string paymentId, CurrencyEnum currency, decimal count, Uri successUrl = null, string themeCode = "default")
        {
            return client.CreatePaymentForm(
                 paymentInfo: new PaymentInfo
                 {
                     PublicKey = publicKey,
                     Amount = new MoneyAmount
                     {
                         ValueDecimal = count,
                         CurrencyEnum = currency
                     },
                     BillId = paymentId,
                     SuccessUrl = successUrl
                 },
                 customFields: new CustomFields
                 {
                     ThemeCode = themeCode
                 });
        }

        public BillResponse CreateBill(
            string paymentId,
            CurrencyEnum currency,
            decimal count,
            string userEmail,
            string userPhone,
            string userIdentity,
            string comment,
            DateTime endPaymentTime,
            Uri successUrl = null,
            string themeCode = "default")
        {
            return client.CreateBill(
                info: new CreateBillInfo
                {
                    BillId = paymentId,
                    Amount = new MoneyAmount
                    {
                        ValueDecimal = count,
                        CurrencyEnum = currency
                    },
                    Comment = comment,
                    ExpirationDateTime = endPaymentTime,
                    Customer = new Customer
                    {
                        Email = userEmail,
                        Account = userIdentity,
                        Phone = userPhone
                    },
                    SuccessUrl = successUrl
                },
                customFields: new CustomFields
                {
                    ThemeCode = themeCode
                }
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signature">Request.Headers["X-Api-Signature-SHA256"]</param>
        /// <param name="notification">query body</param>
        /// <returns></returns>
        public bool ValidQuery(string signature, Notification notification)
        {
            return BillPaymentsUtils.CheckNotificationSignature(
                signature: signature,
                notification: notification,
                merchantSecret: secretKey
            );
        }
    }
}
