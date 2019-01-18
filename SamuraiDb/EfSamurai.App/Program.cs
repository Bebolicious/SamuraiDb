using System;
using EfSamurai.Domain;
using EfSamurai.Data;

namespace EfSamurai.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOneSamurai();
            AddSomeSamurais();
            AddSomeBattles();
        }

        private static void AddSomeBattles()
        {
            throw new NotImplementedException();
        }

        private static void AddSomeSamurais()
        {
            var Shogo = new Samurai { Name = "Sho-Go", Haircut = Haircut.Oicho, Age = 57 };
            var Shohun = new Samurai { Name = "Sho-Hun", Haircut = Haircut.Mohawk, Age = 32 };
            var Jahnnok = new Samurai { Name = "Jahn-Nok", Haircut = Haircut.Chonmage, Age = 65 };

            using (var context = new SamuraiContext())
            {
                context.Samurais.AddRange(Shogo, Shohun, Jahnnok);
                context.SaveChanges();
            }
            
        }

        private static void AddOneSamurai()
        {

            var samurai = new Samurai { Name = "Sho-Yoko", Haircut = Haircut.Oicho, Age = 57 };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
