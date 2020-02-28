using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool.Services
{
    public interface ISportsmanService
    { 
        void InsertSportsman(string name,DateTime? birthday, string phoneNumber, string rank);
        void InsertSportsman(Sportsman item);
        void InsertSportsman(string name, string rank);

        Sportsman UpdateSportsman(long id, string name, DateTime? birthday, string phoneNumber, string rank);
        Sportsman UpdateSportsman(Sportsman item);
        Sportsman UpdateSportsman(long id, string name, string rank);

        bool DeleteSportsman(long id);
        bool DeleteSportsman(Sportsman item);

        Sportsman GetSportsman(long id);
        IEnumerable<Sportsman> GetSportsmen(Func<Sportsman, bool> predicate);
    }
}
