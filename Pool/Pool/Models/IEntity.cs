using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public interface IEntity
    {
        long ID { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}