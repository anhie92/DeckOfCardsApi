using System;
namespace DeckOfCards.Models
{
	public class DrawApi
	{
		public bool success { get; set; }
		public string deck_id { get; set; }
		public List<CardsApi> cards { get; set; }
		public int remaining { get; set; }
	}
}

