using System;
using System.Linq;

namespace Preparation
{
    public class Swap
    {
        public void NumbersSwapUsingTempVariable(int first, int second)
        {
            Console.WriteLine($"Original numbers first = {first}, second = {second}");
            int temp;
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine($"Swapped numbers first = {first}, second = {second}");
        }

        public void NumbersSwapUsingSum(int first, int second)
        {
            Console.WriteLine($"Original numbers first = {first}, second = {second}");

            int sum;
            sum = first + second;

            first = sum - first;
            second = sum - second;

            Console.WriteLine($"Swapped numbers first = {first}, second = {second}");
        }

        public string ReverseStringInCycle(string originalText)
        {
            //Console.WriteLine($"Original text {originalText}");
            string output = "";
            for (int i = originalText.Length -1; i >= 0; i--)
                output += originalText[i];

            //Console.WriteLine($"Reversed text {output}");
            return output;
        }

        public string ReverseStringUsingArrayRevers(string originalText)
        {
            //Console.WriteLine($"Original text {originalText}");
            var tempCharrArray = originalText.ToCharArray();
            Array.Reverse(tempCharrArray);
            var output = new string(tempCharrArray);
            //Console.WriteLine($"Reversed text {output}");
            return output;
        }

        public string ReverseStringUsingLinq(string originalText)
        {
            //Console.WriteLine($"Original text {originalText}");
            var output = new string(originalText.ToCharArray().Reverse().ToArray());
            //Console.WriteLine($"Reversed text {output}");
            return output;
        }

        public bool IsPalindrome(string inputText)
        {
            var revertedText = ReverseStringUsingLinq(inputText);
            var isPalindrome = inputText.Equals(revertedText);
            return isPalindrome;
        }
    }
}
