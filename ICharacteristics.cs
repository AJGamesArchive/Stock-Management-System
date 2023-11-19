using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Interface to force all item child classes to have a type and dictionary of unique characteristics to the item
    public interface ICharacteristics
    {
        // Interface attributes
        public string Make { get; }
        public Dictionary<string, string[]> Characteristics { get; }
    }
}
