using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesUnitarios.Entities;

namespace TestesUnitatiosTest
{
    public class ListValidationsTests
    {
        private readonly ListValidations _validacoes = new();

        public ListValidationsTests()
        {
            _validacoes = new();
        }

        [Fact]
        public void MustRemoveNegativeNumbersOfTheList()
        {
            // Arrange
            List<int> list = [5, -1, -8, 9];
            List<int> expected = [5, 9];

            // Act
            List<int> result = _validacoes.RemoveNegativeNumbers(list);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MustContainNumber9InList()
        {
            // Arrange
            List<int> list = [5, -1, -8, 9];
            int numberInList = 9;

            // Act
            bool result = _validacoes.ListContainsSpecificNumber(list, numberInList);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void MustNotContainNumber10InList()
        {

            // Arrange
            List<int> list = [5, -1, -8, 9];
            int numberInList = 10;

            // Act
            bool result = _validacoes.ListContainsSpecificNumber(list, numberInList);
            // Assert

            Assert.False(result);
        }

        [Fact]
        public void MustMultiplyListElementsBy2()
        {
            // Arrange
            List<int> list = [5, 7, 8, 9];
            List<int> expected = [10, 14, 16, 18];
            int multiplier = 2;

            // Act
            List<int> result = _validacoes.MutipleNumbersOfList(list, multiplier);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MustReturn9AsLargestNumberInList()
        {
            // Arrange
            List<int> list = [5, -1, -8, 9];
            int higherNumber = 9;
            // Act
            int result = _validacoes.ReturnHigherNumberOnTheList(list);
            // Assert
            Assert.Equal(higherNumber, result);
        }

        [Fact]
        public void ShouldReturnNegativeEightAsLowestNumberInList()
        {

            // Arrange
            List<int> list = [5, -1, -8, 9];
            int lowerNumber = -8;

            // Act
            int result = _validacoes.ReturnLowerNumberOnTheList(list);

            // Assert
            Assert.Equal(lowerNumber, result);
        }
    }
}
