using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
     interface IGamerService
    {
        bool Register(Gamer gamer);
        void Update(Gamer gamer);
        void Remove(Gamer gamer);
    }
}
