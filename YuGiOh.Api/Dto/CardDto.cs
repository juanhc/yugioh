using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YuGiOh.Api.Dto
{
    public class CardDtoSet
    {
        [JsonPropertyName("set_name")]
        public string SetName { get; set; }

        [JsonPropertyName("set_code")]
        public string SetCode { get; set; }

        [JsonPropertyName("set_rarity")]
        public string SetRarity { get; set; }

        [JsonPropertyName("set_price")]
        public string SetPrice { get; set; }
    }

    public class CardDtoImage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("image_url_small")]
        public string ImageUrlSmall { get; set; }
    }

    public class CardDtoPrice
    {
        [JsonPropertyName("cardmarket_price")]
        public string CardmarketPrice { get; set; }

        [JsonPropertyName("tcgplayer_price")]
        public string TcgplayerPrice { get; set; }

        [JsonPropertyName("ebay_price")]
        public string EbayPrice { get; set; }

        [JsonPropertyName("amazon_price")]
        public string AmazonPrice { get; set; }
    }

    public class CardDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        [JsonPropertyName("race")]
        public string Race { get; set; }

        [JsonPropertyName("archetype")]
        public string Archetype { get; set; }

        [JsonPropertyName("card_sets")]
        public IList<CardDtoSet> CardSets { get; set; }

        [JsonPropertyName("card_images")]
        public IList<CardDtoImage> CardImages { get; set; }

        [JsonPropertyName("card_prices")]
        public IList<CardDtoPrice> CardPrices { get; set; }
    }
}
