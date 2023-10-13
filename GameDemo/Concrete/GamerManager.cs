using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {
        private IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        public GamerManager()
        {
        }

    
        public bool Register(Gamer gamer)
        {
            if (_verificationService.Verify((gamer)))
            {
                Console.WriteLine("{0} nickname'li kullanıcı eklenmiştir ", gamer.NickName);
                return true;
            }
            else
            {
                Console.WriteLine("Verification failed. Registration unsuccessful.");
                return false;
            }
        }
        public void Remove(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName}'s information deleted successfully.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName}'s information updated successfully.");
        }

     
    }
}
