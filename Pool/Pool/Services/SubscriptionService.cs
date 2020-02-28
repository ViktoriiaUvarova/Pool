using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private PoolContext poolContext;

        public bool DeleteSubscription(long id)
        {
            var item = GetSubscription(id);
            var result = DeleteSubscription(item);
            return result;
        }

        public bool DeleteSubscription(Subscription item)
        {
            var result = poolContext.Subscriptions.Remove(item);
            return result;
        }

        public Subscription GetSubscription(long id)
        {
            var result = GetSubscriptions(m => m.ID == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<Subscription> GetSubscriptions(Func<Subscription, bool> predicate)
        {
            var result = poolContext.Subscriptions.Where(predicate);
            return result;
        }

        public void InsertSubscription(string sportsmanID, long coachID, string poolID, DateTime? clearanceDate, DateTime? term)
        {
            var item = new Subscription()
            {
                SportsmanID = sportsmanID,
                CoachID = coachID,
                PoolID = poolID,
                ClearanceDate = clearanceDate,
                Term = term
            };

            InsertSubscription(item);
        }

        public void InsertSubscription(Subscription item)
        {
            poolContext.Subscriptions.Add(item);
        }

        public void InsertSubscription(string sportsmanID, string poolID, DateTime? clearanceDate, DateTime? term)
        {
            InsertSubscription(sportsmanID, poolID, clearanceDate, term);
        }

        public Subscription UpdateSubscription(long id, string sportsmanID, long coachID, string poolID, DateTime? clearanceDate, DateTime? term)
        {
            var item = GetSubscription(id);

            item.SportsmanID = sportsmanID;
            item.CoachID = coachID;
            item.PoolID = poolID;
            item.ClearanceDate = clearanceDate;
            item.Term = term;

            return item;
        }

        public Subscription UpdateSubscription(Subscription item)
        {
            var result = UpdateSubscription(item.ID, item.SportsmanID, item.CoachID, item.PoolID, item.ClearanceDate, item.Term);
            return result;
        }

        public Subscription UpdateSubscription(long id, DateTime? clearanceDate, DateTime? term)
        {
            var item = GetSubscription(id);

            item.ClearanceDate = clearanceDate;
            item.Term = term;

            return item;
        }
    }
}
