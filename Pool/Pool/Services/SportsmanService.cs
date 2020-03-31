/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

 namespace Pool.Services
{
    public class SportsmanService : ISportsmanService
    {
        private PoolContext poolContext;

        public bool DeleteSportsman(long id)
        {
            var item = GetSportsman(id);
            var result = DeleteSportsman(item);
            return result;
        }

        public bool DeleteSportsman(Sportsman item)
        {
            var result = poolContext.Sportsmen.Remove(item);
            return result;
        }

        public Sportsman GetSportsman(long id)
        {
            var result = GetSportsmen(m => m.ID == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<Sportsman> GetSportsmen(Func<Sportsman, bool> predicate)
        {
            var result = poolContext.Sportsmen.Where(predicate);
            return result;
        }

        public void InsertSportsman(string name, DateTime? birthday, string phoneNumber, string rank)
        {
            var item = new Sportsman()
            {
                Name = name,
                Birthday = birthday,
                PhoneNumber = phoneNumber,
                Rank = rank
            };

            InsertSportsman(item);
        }

        public void InsertSportsman(Sportsman item)
        {
            poolContext.Sportsmen.Add(item);
        }

        public void InsertSportsman(string name, string rank)
        {
            InsertSportsman(name, null, null, rank);
        }

        public Sportsman UpdateSportsman(long id, string name, DateTime? birthday, string phoneNumber, string rank)
        {
            var item = GetSportsman(id);

            item.Name = name;
            item.Birthday = birthday;
            item.PhoneNumber = phoneNumber;
            item.Rank = rank;

            return item;

        }

        public Sportsman UpdateSportsman(Sportsman item)
        {
            var result = UpdateSportsman(item.ID, item.Name, item.Birthday, item.PhoneNumber, item.Rank);
            return result;
        }

        public Sportsman UpdateSportsman(long id, string name, string rank)
        {
            var item = GetSportsman(id);
            
                item.Name = name;
                item.Rank = rank;

            return item;
        }
    }
}
*/