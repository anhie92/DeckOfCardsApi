using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeckOfCards.Models;
using Flurl.Http;

namespace DeckOfCards.Controllers
{
    public class DeckOfCardsController : Controller
    {


        public IActionResult Index()
        {
            DeckApi deck;
            string apiUri = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            var apiTask = apiUri.GetJsonAsync<DeckApi>();
                apiTask.Wait();
                deck = apiTask.Result;
                return View(deck); 
        }



        public ActionResult Draw(string id)
        {
            string apiUri = $"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";
            var apiTask = apiUri.GetJsonAsync<DrawApi>();
            apiTask.Wait();
            DrawApi result = apiTask.Result;
            return View(result);
        }



    }
}
