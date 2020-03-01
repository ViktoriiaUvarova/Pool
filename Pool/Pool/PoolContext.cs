using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Pool
{
    public class PoolContext:DbContext
    {
        public DbSet<Sportsman> Sportsmen;
        public DbSet<Coach> Coaches;
        public DbSet<SwimPool> Pools;
        public DbSet<Subscription> Subscriptions;

        public PoolContext():base("ConnectionString")
        {
            
        }
    }
}
