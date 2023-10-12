using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    class Gamer
    {
        public string NickName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public string PhoneNumber { get; set; }
        public int DateOfYear { get; set; }
        public List<Game> PurchasedGames { get; set; } = new List<Game>();

    }
}
