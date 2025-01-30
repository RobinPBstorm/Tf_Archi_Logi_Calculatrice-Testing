using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Model.Exceptions
{
    public class NANException: Exception
    {
        public NANException(string message = "Ce n'est pas une valeur convertible en chiffre!") : base(message) { }
    }
}
