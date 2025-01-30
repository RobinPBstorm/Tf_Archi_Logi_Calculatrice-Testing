using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Model.Exceptions
{
    public class IntValueOutOfRangeException: Exception
    {
        public IntValueOutOfRangeException(string message = "La valeur dépasse la limite des int"): base(message) { }
    }
}
