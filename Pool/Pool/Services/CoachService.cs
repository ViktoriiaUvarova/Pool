using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;
using Pool;

/*namespace Pool.Services
{
    public class СoachService : ICoachService
    {
        private PoolContext poolContext;

        public bool DeleteCoach(long id) 
        {
            var item = GetCoach(id);
            var result = DeleteCoach(item);
            return result;
        }

        public bool DeleteCoach(Coach item)
        {
            var result = poolContext.Coaches.Remove(item);
            return result;
        }

        public Coach GetCoach(long id)
        {
            var result = GetCoaches(m => m.ID == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<Coach> GetCoaches(Func<Coach,bool> predicate)
        {
            var result = poolContext.Coaches.Where(predicate);
            return result;
        }

        public void InsertCoach(string name, DateTime? birthday, string phoneNumber, string rank)
        {
            var item = new Coach()
            {
                Name = name,
                Birthday = birthday,
                PhoneNumber = phoneNumber,
                Rank = rank
            };

            InsertCoach(item);
        }

        public void InsertCoach(Coach item)
        {
            poolContext.Coaches.Add(item);
        }

        public void InsertCoach(string name, string rank)
        {
            InsertCoach(name, null, null, rank);
        }

        public Coach UpdateCoach(long id, string name, DateTime? birthday, string phoneNumber, string rank)
        {
            var item = GetCoach(id);

            item.Name = name;
            item.Birthday = birthday;
            item.PhoneNumber = phoneNumber;
            item.Rank = rank;

            return item;
        }

        public Coach UpdateCoach(Coach item)
        {
            var result = UpdateCoach(item.ID, item.Name, item.Birthday, item.PhoneNumber, item.Rank);
            return result;
        }

        public Coach UpdateCoach(long id, string name, string rank)
        {
            var item = GetCoach(id);

            item.Name = name;
            item.Rank = rank;

            return item;
        }
    }

}
*/