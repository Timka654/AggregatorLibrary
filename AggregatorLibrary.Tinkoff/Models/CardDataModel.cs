namespace AggregatorLibrary.Tinkoff.Models
{
    public class CardDataModel
    {
        public long PAN { get; set; }

        public short ExpDate { get; set; }

        public string CardHolder { get; set; }

        public string CVV { get; set; }

        public string ECI { get; set; }

        public string CAVV { get; set; }
    }
}
