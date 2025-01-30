using Calculatrice.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Interfaces
{
    public interface ICalculator
    {
        int Addition(int valeur1, int valeur2);
        float Addition(object valeur1, object valeur2);
        int Soustraction(int valeur1, int valeur2);
        float Division(int valeur1, int valeur2);
        int Multiplication(int valeur1, int valeur2);
        float RacineCarree(int valeur);
    }
}
