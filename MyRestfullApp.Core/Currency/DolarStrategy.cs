using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MyRestfullApp.Core.Currency
{
    public class DolarStrategy : ICurrencyStrategy
    {
        private const string dolarUrl = "https://www.bancoprovincia.com.ar/Principal/Dolar";

        public Price GetPrice()
        {
            Uri dolarUri = new Uri(dolarUrl);
            WebRequest request = WebRequest.Create(dolarUri);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseData = reader.ReadToEnd();
            List<string> data = JsonConvert.DeserializeObject<List<string>>(responseData);

            Price price = new Price
            {
                Purchase = Convert.ToDecimal(data[(int)PriceFields.purchase]),
                Sale = Convert.ToDecimal(data[(int)PriceFields.sale]),
                Actualized = data[(int)PriceFields.actualized]
            };

            return price;
        }
    }
}
