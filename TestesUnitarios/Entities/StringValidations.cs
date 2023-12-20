using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios.Entities
{
    public class StringValidations
    {
        public int ReturnLengthCharacter(string text)
        {
            var totalOfCharacters = text.Length;
            return totalOfCharacters;
        }

        public bool ContainsWord(string text, string word)
        {
            var contains = text.Contains(word);
            return contains;
        }

        public bool TextEndsWith(string text, string word)
        {
            var endWith = text.EndsWith(word);
            return endWith;
        }
    }
}
