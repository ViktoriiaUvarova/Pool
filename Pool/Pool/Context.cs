using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Context
{
    public class Context
    {
        public List<Sportsman> Sportsmen = new List<Sportsman>();
        public List<Coach> Coachs = new List<Coach>();
        public List<SwimPool> Pools = new List<SwimPool>();

        public Context() {

            Sportsmen.Add(new Sportsman() { Name = "Viktoriia Uvarova", PhoneNumber = "380665883835", Rank = "Internationat Master of Sport" });
            Sportsmen.Add(new Sportsman() { Name = "Ivan Ivarov", PhoneNumber = "380965993634", Rank = "I" });
            Coachs.Add(new Coach() { Name = "Krasnogor Tetyana", PhoneNumber = "380232323553", Rank = "Honored Master of Sport" });
            Coachs.Add(new Coach() { Name = "Petr Petrov", PhoneNumber = "38669664836", Rank = "Master of Sport" });
            Pools.Add(new SwimPool() { NamePool = "Akvarena", Length = 50, Location = "Klochkivska street 43/47" });
            Pools.Add(new SwimPool() { NamePool = "Kharkiv", Length = 25, Location = "Nemishlyanska" });
         }
    }
}
