namespace AggregatorLibrary.SberBank.Models
{
    public class SberBankReceiptModel
    {
        public int receiptStatus { get; set; }

        public string uuid { get; set; }

        public int shift_number { get; set; }

        public int receipt_number { get; set; }

        public string receipt_datetime { get; set; }

        public string fn_number { get; set; }

        public string ecr_registration_number { get; set; }

        public int fiscal_document_number { get; set; }

        public string fiscal_document_attribute { get; set; }

        public string amount_total { get; set; }

        public string serial_number { get; set; }

        public string fnsSite { get; set; }

        public SberBankOFDModel OFD { get; set; }
    }
}
