using System;
namespace DeckOfCards.Models
{
	public class CardsApi
	{
		public string code { get; set; }
		public string image { get; set; }
		public string value { get; set; }
		public string suit { get; set; }
        public bool Keep { get; set; } = false;
    }
}

