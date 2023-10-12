using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class SalesManager:ISalesService
    {
        public void SellGame(Gamer gamer, Game game)
        {
            if (game.offer != null)
            {
                double discountAmount = (game.Price * game.offer.Ratio) / 100;
                game.Price -= discountAmount;
            }
            gamer.PurchasedGames.Add(game);
            Console.WriteLine($"{game.Name} sold to {gamer.FirstName} {gamer.LastName} for {game.Price}!");
        }
    }
}
