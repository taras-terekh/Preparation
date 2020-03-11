using System.Collections.Generic;
using System.Linq;

namespace Preparation
{
    public class Caesar
    {
        private static Dictionary<int, string> AlphabeticOrder => new Dictionary<int, string>
        {
            {0, "A"},
            {1, "B"},
            {2, "C"},
            {3, "D"},
            {4, "E"},
            {5, "F"},
            {6, "G"},
            {7, "H"},
            {8, "I"},
            {9, "J"},
            {10, "K"},
            {11, "L"},
            {12, "M"},
            {13, "N"},
            {14, "O"},
            {15, "P"},
            {16, "Q"},
            {17, "R"},
            {18, "S"},
            {19, "T"},
            {20, "U"},
            {21, "V"},
            {22, "W"},
            {23, "X"},
            {24, "Y"},
            {25, "Z"},
        };

        public string CaesarСipher(string textToEncrypt, int shift, Coding type)
        {
            string outputText = "";
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                var letter = textToEncrypt[i].ToString();
                if (IsLetter(letter))
                {
                    outputText += letter;
                    continue;
                }
                int index;
                if (type == Coding.Encode)
                {
                    index = ShiftIndexInAlphabet(letter, shift, Coding.Encode);
                    index %= AlphabeticOrder.Count;
                }
                else
                {
                    index = ShiftIndexInAlphabet(letter, shift, Coding.Decode);
                    if (index < 0)
                        index += AlphabeticOrder.Count;
                }
                
                outputText += AlphabeticOrder.Select(item => item.Value).ElementAt(index);
            }
            return outputText;  
        }

        private bool IsLetter(string symbol) => symbol.Any(symbol => !char.IsLetter(symbol));

        private int ShiftIndexInAlphabet(string currentLetter, int shift, Coding type)
        {
            int index = 0;
            index = type == Coding.Encode
                ? AlphabeticOrder.FirstOrDefault(item => item.Value == currentLetter).Key + shift
                : AlphabeticOrder.FirstOrDefault(item => item.Value == currentLetter).Key - shift;
            return index;
        }
    }

    public enum Coding 
    { 
        Encode,
        Decode
    }
}
