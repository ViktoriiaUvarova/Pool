using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool.Services
{
    public interface ICoachService
    {
        void InsertCoach(string name, DateTime? birthday, string phoneNumber, string rank);
        void InsertCoach(Coach item);
        void InsertCoach(string name, string rank);

        Coach UpdateCoach(long id, string name, DateTime? birthday, string phoneNumber, string rank);
        Coach UpdateCoach(Coach item);
        Coach UpdateCoach(long id, string name, string rank);

        bool DeleteCoach(long id);
        bool DeleteCoach(Coach item);

        Coach GetCoach(long id);
        IEnumerable<Coach> GetCoaches(Func<Coach,bool> predicate);
    }
}
