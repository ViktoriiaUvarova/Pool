using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public abstract class Entity:IEntity
    {
        public long ID { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

    public interface IEntity
    {

    }        
}
