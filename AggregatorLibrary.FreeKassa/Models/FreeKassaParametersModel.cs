namespace AggregatorLibrary.FreeKassa.Models
{
    public class FreeKassaParametersModel
    {
        public int MerchantId { get; set; }

        public double Amount { get; set; } = 3;

        public int OrderId { get; set; }

        public string SignKey { get; set; }
    }
}
