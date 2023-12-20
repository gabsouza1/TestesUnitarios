using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesUnitarios.Entities;

namespace TestesUnitatiosTest
{
    public class StringValidationsTests
    {
        private readonly StringValidations _validations = new();

        public StringValidationsTests()
        {
            _validations = new();
        }
        [Fact]
        public void MustReturn6QuantityCharactersOfWordMatrix()
        {

            // Arrange
            string text = "Matrix";
            int expectedResult = 6;

            // Act
            int result = _validations.ReturnLengthCharacter(text);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MustContainAnyWordInText()
        {
            // Arrange
            string text = "Esse é um texto qualquer";
            string specificWord = "qualquer";

            // Act
            bool result = _validations.ContainsWord(text, specificWord);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DontContainTheTestWordInText()
        {
            // Arrange
            string text = "Esse é um texto qualquer";
            string specificWord = "teste";

            // Act
            bool result = _validations.ContainsWord(text, specificWord);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TextMustEndWithWordWanted()
        {
            // Arrange
            string text = "Começo, meio e fim do texto procurado";
            string specificWord = "procurado";

            // Act
            bool result = _validations.TextEndsWith(text, specificWord);

            // Assert
            Assert.True(result);
        }
    }
}
