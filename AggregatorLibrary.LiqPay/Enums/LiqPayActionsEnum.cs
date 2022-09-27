using System.Runtime.Serialization;

namespace AggregatorLibrary.LiqPay.Enums
{
    public enum LiqPayActionsEnum
    {
        [EnumMember(Value = "pay")]
        Pay,

        [EnumMember(Value = "hold")]
        Hold,

        [EnumMember(Value = "paysplit")]
        Paysplit,

        [EnumMember(Value = "subscribe")]
        Subscribe,

        [EnumMember(Value = "paydonate")]
        Paydonate,

        [EnumMember(Value = "auth")]
        Auth,

        [EnumMember(Value = "regular")]
        Regular,

        [EnumMember(Value = "invoice_bot")]
        InvoiceBot
    }
}
