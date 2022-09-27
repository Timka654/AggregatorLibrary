namespace AggregatorLibrary.Tinkoff.Models
{
    /// <summary>
    /// https://oplata.tinkoff.ru/develop/api/payments/finishauthorize-response/
    /// </summary>
    public class ACSResponseModel
    {
        public string MD { get; set; }

        public string PaReq { get; set; }
    }
}
