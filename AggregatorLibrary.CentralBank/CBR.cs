using AggregatorLibrary.CentralBank.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace AggregatorLibrary.CentralBank
{
    /// <summary>
    /// Апи для взаимодействия с центральным банком России
    /// </summary>
    public class CBR
    {
        public static string DailyQueryUrl = "https://www.cbr.ru/scripts/XML_daily.asp";

        public static CBRDailyQueryResultModel DailyQuery()
        {
            using (WebClient wc = new WebClient())
            {
                using (MemoryStream ms =
                    new MemoryStream(wc.DownloadData(DailyQueryUrl))
                    )
                {
                    XmlReader xs = XmlReader.Create(ms);

                    CBRDailyQueryResultModel result = new CBRDailyQueryResultModel();
                    xs.Read();
                    xs.Read();

                    xs.MoveToNextAttribute();
                    var date = xs.Value.Split('.');
                    result.Date = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

                    xs.MoveToNextAttribute();
                    result.Name = xs.Value;

                    result.DailyValuteList = new List<CBRDailyValuteModel>();

                    while (xs.Read() && xs.Read() && xs.NodeType != XmlNodeType.None)
                    {
                        var r = new CBRDailyValuteModel();
                        //xs.MoveToElement();
                        r.NumCode = int.Parse(xs.ReadElementContentAsString());
                        r.CharCode = xs.ReadElementContentAsString();
                        r.Nominal = int.Parse(xs.ReadElementContentAsString());
                        r.Name = xs.ReadElementContentAsString();
                        r.Value = double.Parse(xs.ReadElementContentAsString(), CultureInfo.GetCultureInfo("ru-RU"));
                        result.DailyValuteList.Add(r);
                    }

                    return result;
                }
            }
        }
    }
}
