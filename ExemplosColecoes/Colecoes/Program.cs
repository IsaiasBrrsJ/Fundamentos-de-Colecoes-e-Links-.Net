using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];
            //Começa em 0 e vai até (n -1);
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            Console.WriteLine("Percorrendo array pelo For");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }
            Console.WriteLine("Percorrendo array pelo ForEach");
            foreach (var item in arrayInteiros)
            {
                Console.WriteLine(item);
            }

        }
    }
}