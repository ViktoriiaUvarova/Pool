using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool.Services
{
    public interface ISubscriptionService
    {
        void InsertSubscription(string sportsmanID, long coachID, string poolID, DateTime? clearanceDate, DateTime? term);
        void InsertSubscription(Subscription item);
        void InsertSubscription(string sportsmanID, string poolID, DateTime? clearanceDate, DateTime? term);

        Subscription UpdateSubscription(long id, string sportsmanID, long coachID, string poolID, DateTime? clearanceDate, DateTime? term);
        Subscription UpdateSubscription(Subscription item);
        Subscription UpdateSubscription(long id, DateTime? clearanceDate, DateTime? term);

        bool DeleteSubscription(long id);
        bool DeleteSubscription(Subscription item);

        Subscription GetSubscription(long id);
        IEnumerable<Subscription> GetSubscriptions(Func<Subscription, bool> predicate);
    }
}
