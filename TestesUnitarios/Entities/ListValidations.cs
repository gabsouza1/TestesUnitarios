using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios.Entities
{
    public class ListValidations
    {
        public List<int> RemoveNegativeNumbers(List<int> list)
        {
            var listWithoutNegative = list.Where(x => x > 0);
            return listWithoutNegative.ToList();
        }

        public bool ListContainsSpecificNumber(List<int> list, int number)
        {
            var contains = list.Contains(number);
            return contains;
        }

        public List<int> MutipleNumbersOfList(List<int> list, int number)
        {
            var multipliedList = list.Select(x => x * number).ToList();
            return multipliedList;
        }

        public int ReturnHigherNumberOnTheList(List<int> list)
        {
            return list.Max();
        }

        public int ReturnLowerNumberOnTheList(List<int> list)
        {
            return list.Min();
        }
    }
}
