using Calculatrice.Interfaces;
using Calculatrice.Model;
using Calculatrice.Model.Exceptions;
using Moq;

namespace CalculatriceTesting.Models
{
    public class CalculatriceTest
    {
        private readonly ICalculator _calculatrice;
        public CalculatriceTest()
        {
            _calculatrice = new Calculator();

            //_calculatrice = Mock.Of<ICalculator>();
        }

        [Fact]
        public void Addition_AdditionBetween2Integer()
        {
            // Arrange
            // Préparation des Objets nécessaire pour ce test
            int valeur1 = 1;
            int valeur2 = 2;
            //Mock.Get(_calculatrice).Setup((calc) => calc.Addition(1, 2)).Returns(3);

            // Act
            // méthode que l'on va essayer
            int result = _calculatrice.Addition(valeur1, valeur2);

            // Assert
            // Vérifier de la valeur otenue dan l'Act face à ce attend
            Assert.Equal(3, result);

            // Assert.False(result);
            // Assert.Null(result);
            // Assert.Throws<ArgumentException>(result);
        }

        [Fact]
        public void Addition_AdditionWithMaxValue_ThrowException()
        {
            // Arrange
            int valeur1 = Int32.MaxValue;
            int valeur2 = 1;

            // Act
            Action action = () => _calculatrice.Addition(valeur1, valeur2);

            // Assert
            Assert.Throws<IntValueOutOfRangeException>(action);
        }

        [Fact]
        public void Addition_AdditionBetween2IntegerBoxed()
        {
            // Arrange
            object valeur1 = (object)1;
            object valeur2 = (object)2;

            // Act
            float result = _calculatrice.Addition(valeur1, valeur2);

            // Assert
            Assert.Equal(3f, result);
        }
        [Fact]
        public void Addition_AdditionBetween2Float()
        {
            // Arrange
            object valeur1 = 1.5f;
            object valeur2 = 1.5f;

            // Act
            float result = _calculatrice.Addition(valeur1, valeur2);

            // Assert
            Assert.Equal(3f, result);
        }
        [Fact]
        public void Addition_AdditionWith1StringNotConvertible_NANException()
        {
            // Arrange
            object valeur1 = 1.5f;
            object valeur2 = "mot";

            // Act
            Action addition = () => _calculatrice.Addition(valeur1, valeur2);

            // Assert
            Assert.Throws<NANException>(addition);
        }

        [Fact]
        public void Soustraction_SoustractionBetween2Integer()
        {
            // Arrange
            int valeur1 = 1;
            int valeur2 = 2;

            // Act
            int result = _calculatrice.Soustraction(valeur1, valeur2);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Division_DividedByZero_ThrowDividedByZeroException()
        {
            // Arrange
            int valeur1 = 5;
            int valeur2 = 0;

            // Act
            Action division = () => _calculatrice.Division(valeur1, valeur2);

            // Assert
            Assert.Throws<DivideByZeroException>(division);
        }

        [Fact]
        public void Division_Divided2Integer_FloatResult()
        {
            // Arrange
            int valeur1 = 5;
            int valeur2 = 2;

            // Act
            float result = _calculatrice.Division(valeur1, valeur2);

            // Assert
            Assert.Equal(2.5f, result);
        }

        [Fact]
        public void Multiplication_Multiplication2Integer()
        {
            // Arrange
            int valeur1 = 5;
            int valeur2 = 2;

            // Act
            float result = _calculatrice.Multiplication(valeur1, valeur2);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void RacineCarree_RacineCarree()
        {
            // Arrange
            int valeur = 4;

            // Act
            float result = _calculatrice.RacineCarree(valeur);

            // Assert
            Assert.Equal(2f, result);
        }

        [Fact]
        public void RacineCarree_NegativeValueInput_RacineCarreeNegativeException()
        {
            // Arrange
            int valeur = -1;

            // Act
            Action racineCarree = () => _calculatrice.RacineCarree(valeur);

            // Assert
            Assert.Throws<RacineCarreeNegativeException>(racineCarree);
        }
    }
}