using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Interface o force entities to implement method(s) to check for matching atrributes
    public interface IEntities
    {
        public bool hasMatchingAttribute(int id);
    }
}
