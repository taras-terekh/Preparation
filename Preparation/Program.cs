using System;

namespace Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            Swap swap = new Swap();

            Caesar caesar = new Caesar();
            //caesar.EncryptString("ZXC WEQA", 3);
            Console.WriteLine(caesar.CaesarСipher("ABCD,, ERSXZW", 3, Coding.Decode));

        }
    }
}
