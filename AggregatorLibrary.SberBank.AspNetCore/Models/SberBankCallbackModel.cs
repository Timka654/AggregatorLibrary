using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System;

namespace AggregatorLibrary.SberBank.AspNetCore.Models
{
    public class SberBankCallbackModel
    {
        [FromQuery(Name = "mdOrder")]
        public string Order { get; set; }

        [FromQuery(Name = "amount")]
        public string Amount { get; set; }

        [FromQuery(Name = "orderNumber")]
        public string OrderNumber { get; set; }

        [FromQuery(Name = "checksum")]
        public string CheckSum { get; set; }

        [FromQuery(Name = "operation")]
        public string Operation { get; set; }

        [FromQuery(Name = "status")]
        public string Status { get; set; }

        public bool ValidateAsymmetricsSignature(string x509Key, HashAlgorithmName alg)
        {
            X509Certificate2 x509 = new X509Certificate2(Encoding.UTF8.GetBytes(x509Key));

            using (var rsa = x509.GetRSAPublicKey())
            {
                var lineData = String.Join(";", "amount", Amount, "mdOrder", Order, "operation", Operation, "status", Status) + ";";

                var encData = Encoding.UTF8.GetBytes(lineData);

                var hexString = FromHex(CheckSum.ToLower());

                return rsa.VerifyData(
                    encData,
                    hexString,
                    alg,
                    RSASignaturePadding.Pkcs1);
            }
        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            return Enumerable.Range(0, hex.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                 .ToArray();
        }
    }
}
