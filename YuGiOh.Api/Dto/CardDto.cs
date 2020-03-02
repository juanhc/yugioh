using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuGiOh.Api.Dto
{
    public class CardDtoSet
    {
        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_code")]
        public string SetCode { get; set; }

        [JsonProperty("set_rarity")]
        public string SetRarity { get; set; }

        [JsonProperty("set_price")]
        public string SetPrice { get; set; }
    }

    public class CardDtoImage
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("image_url_small")]
        public string ImageUrlSmall { get; set; }
    }

    public class CardDtoPrice
    {
        [JsonProperty("cardmarket_price")]
        public string CardmarketPrice { get; set; }

        [JsonProperty("tcgplayer_price")]
        public string TcgplayerPrice { get; set; }

        [JsonProperty("ebay_price")]
        public string EbayPrice { get; set; }

        [JsonProperty("amazon_price")]
        public string AmazonPrice { get; set; }
    }

    public class CardDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("card_sets")]
        public IList<CardDtoSet> CardSets { get; set; }

        [JsonProperty("card_images")]
        public IList<CardDtoImage> CardImages { get; set; }

        [JsonProperty("card_prices")]
        public IList<CardDtoPrice> CardPrices { get; set; }
    }
}
