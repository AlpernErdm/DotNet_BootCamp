using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            { NationalityId = "12345678900", FirstName = "Alperen", LastName = "Erdem", NickName = "Alpiş", PhoneNumber = "50786634434", DateOfYear = 2000 };
            IGamerService gamerService = new GamerManager();

            Game game = new Game { Name = "Valorant ", Id = 1,Price=100 };
            Offer offer = new Offer { Name = "Summer Sale", Ratio = 10 };
            IOfferService offerService = new OfferManager();
           // offerService.(game, offer);

            ISalesService salesService = new SalesManager();
            salesService.SellGame(gamer, game);

        }
    }
}
