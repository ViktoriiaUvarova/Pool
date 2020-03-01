using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

/*namespace Pool.Services
{
    public class SwimPoolService : ISwimPoolService
    {
        private PoolContext poolContext;

        public bool DeleteSwimPool(SwimPool item)
        {
            var result = poolContext.Pools.Remove(item);
            return result;
        }

        public bool DeleteSwimPool(long id)
        {
            var item = GetSwimPool(id);
            var result = DeleteSwimPool(item);
            return result;
        }

        public SwimPool GetSwimPool(long id)
        {
            var result = GetSwimPools(m => m.ID == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<SwimPool> GetSwimPools(Func<SwimPool, bool> predicate)
        {
            var result = poolContext.Pools.Where(predicate);
            return result;
        }

        public void InsertSwimPool(string namePool, DateTime? yearsOpen, int length, string location)
        {
            var item = new SwimPool()
            {
                NamePool = namePool,
                YearsOpen = yearsOpen,
                Length = length,
                Location = location
            };

            InsertSwimPool(item);
        }

        public void InsertSwimPool(SwimPool item)
        {
            poolContext.Pools.Add(item);
        }

        public void InsertSwimPool(string namePool, int length)
        {
            InsertSwimPool(namePool, null, length, null);
        }

        public SwimPool UpdateSwimPool(long id, string namePool, DateTime? yearsOpen, int length, string location)
        {
            var item = GetSwimPool(id);

            item.NamePool = namePool;
            item.YearsOpen = yearsOpen;
            item.Length = length;
            item.Location = location;

            return item;
        }

        public SwimPool UpdateSwimPool(SwimPool item)
        {
            var result = UpdateSwimPool(item.ID, item.NamePool, item.YearsOpen, item.Length, item.Location);
            return result;
        }

        public SwimPool UpdateSwimPool(long id, string namePool, int length)
        {
            var item = GetSwimPool(id);

            item.NamePool = namePool;
            item.Length = length;

            return item;
        }
    }
}
*/