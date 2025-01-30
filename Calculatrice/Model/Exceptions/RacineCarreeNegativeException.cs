using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Model.Exceptions
{
    public class RacineCarreeNegativeException: Exception
    {
        public RacineCarreeNegativeException(string message = "La racine carrée d'un nombre négative ne donne pas un nombre réel"): base(message) { }
    }
}
