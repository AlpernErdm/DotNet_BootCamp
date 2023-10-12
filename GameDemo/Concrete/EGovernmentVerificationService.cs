using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class EGovernmentVerificationService
    {
        public bool Verify(Gamer gamer)
        {
            return gamer.NationalityId.Length == 11 && gamer.DateOfYear > 1900;
        }
    }
}
