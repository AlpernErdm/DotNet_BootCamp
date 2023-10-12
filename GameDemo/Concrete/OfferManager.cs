using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class OfferManager:IOfferService
    {
        public void Add(Game game, Offer offer)
        {
            game.offer = offer;
            Console.WriteLine($"Campaign {offer.Name} added to {game.Name}!");
        }

        public void Update(Game game, Offer offer)
        {
            game.offer = offer;
            Console.WriteLine($"Campaign for {game.Name} updated to {offer.Name}!");
        }

        public void Delete(Game game)
        {
            game.offer = null;
        }
    }
}
