using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool.Services
{
    public interface ISwimPoolService
    {
        void InsertSwimPool(string namePool, DateTime? yearsOpen, int length, string location);
        void InsertSwimPool(SwimPool item);
        void InsertSwimPool(string namePool, int length);

        SwimPool UpdateSwimPool(long id, string namePool, DateTime? yearsOpen, int length, string location);
        SwimPool UpdateSwimPool(SwimPool item);
        SwimPool UpdateSwimPool(long id, string namePool, int length);

        bool DeleteSwimPool(SwimPool item);
        bool DeleteSwimPool(long id);

        SwimPool GetSwimPool(long id);
        IEnumerable<SwimPool> GetSwimPools(Func<SwimPool, bool> predicate);
    }
}
