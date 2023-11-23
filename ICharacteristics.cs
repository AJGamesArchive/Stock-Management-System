using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Interface to force item child classes to have a type and dictionary of unique characteristics to the item
    interface ICharacteristics
    {
        // Interface attributes
        string getMake();
        string[] getCharacteristics();
    }
}
