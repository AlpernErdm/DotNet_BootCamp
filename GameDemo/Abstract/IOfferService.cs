using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
     interface IOfferService
    {
        void Add(Game game, Offer offer);
        void Update(Game game, Offer offer);
        void Delete(Game game);
    }
}
