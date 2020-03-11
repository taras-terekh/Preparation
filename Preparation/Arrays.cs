using System;

namespace Preparation
{
    public class Arrays
    {
        // Multiplication Table 
        public void MultiplicationTable(int rows, int colums)
        {
            for (int i = 1; i <=rows; i++)
            {
                for (int j = 1; j <=colums; j++)
                {
                    Console.Write(string.Format("{0:d} ", i*j));
                }
                Console.WriteLine();
            }
        }
    }
}
