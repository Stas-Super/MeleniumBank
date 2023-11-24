using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll
{
    public class Item
    {
        public Item(
            double foreignExchangeBuy,
            double foreignExchangeSale,
            DateTime rateTimestamp,
            string currency)
        {
            ForeignExchangeBuy = foreignExchangeBuy;
            ForeignExchangeSale = foreignExchangeSale;
            RateTimestamp = rateTimestamp;
            Currency = currency;
        }

        [JsonProperty("foreignExchangeBuy")]
        public double ForeignExchangeBuy { get; set; }
       
        [JsonProperty("foreignExchangeSale")]
        public double ForeignExchangeSale { get; set; }
        
        [JsonProperty("rateTimestamp")]
        public DateTime RateTimestamp { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

}
