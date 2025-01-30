using Calculatrice.Interfaces;
using Calculatrice.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Model
{
    public class Calculator: ICalculator
    {

        public int Addition(int valeur1, int valeur2)
        {
            if (valeur1 > Int32.MaxValue - valeur2)
            {
                throw new IntValueOutOfRangeException();
            }
            return valeur1 + valeur2;
        }

        public float Addition(object valeur1, object valeur2)
        {
            if (valeur1 is Int32  && valeur2 is Int32 )
            {
                return Addition((int)valeur1, (int)valeur2);
            }
            float valeurTemp1;
            float valeurTemp2;
            if (!float.TryParse(valeur1.ToString(),out valeurTemp1) || !float.TryParse(valeur2.ToString(), out valeurTemp2))
            {
                throw new NANException();
            }

            return valeurTemp1 + valeurTemp2;
        }
        
        public int Soustraction(int valeur1, int valeur2)
        {
            return valeur1 - valeur2;
        }

        public float Division(int valeur1, int valeur2)
        {
            if (valeur2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (float)valeur1 / valeur2;
        }
        public int Multiplication(int valeur1, int valeur2)
        {
            return valeur1 * valeur2;
        }

        public float RacineCarree(int valeur)
        {
            if (valeur < 0)
            {
                throw new RacineCarreeNegativeException();
            }
            return MathF.Sqrt(valeur);
        }
    }
}
