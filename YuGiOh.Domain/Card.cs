using System.Collections.Generic;

namespace YuGiOh.Domain
{
    public class CardSet
    {
        public int Id { get; set; }
        public string SetName { get; set; }
        public string SetCode { get; set; }
        public string SetRarity { get; set; }
        public string SetPrice { get; set; }
    }

    public class CardImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
    }

    public class CardPrice
    {
        public int Id { get; set; }
        public string CardmarketPrice { get; set; }
        public string TcgplayerPrice { get; set; }
        public string EbayPrice { get; set; }
        public string AmazonPrice { get; set; }
    }

    public class Card
    {
        public Card()
        {
            CardSets = new List<CardSet>();
            CardImages = new List<CardImage>();
            CardPrices = new List<CardPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Race { get; set; }
        public string Archetype { get; set; }
        public IList<CardSet> CardSets { get; set; }
        public IList<CardImage> CardImages { get; set; }
        public IList<CardPrice> CardPrices { get; set; }
    }
}
