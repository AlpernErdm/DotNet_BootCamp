using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface ISalesService
    {
        void SellGame(Gamer gamer, Game game);
    }
}
