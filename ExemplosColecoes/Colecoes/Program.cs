using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Implementando BubleSort
            OperacoesArray op = new OperacoesArray();
            int[] array = { 6, 3, 8, 1, 9 };
            string[] arrayString = op.ConverterParaArrayString(array);
            int[] arrayCopia = new int[10];
            //Console.WriteLine("Array original");
            //op.ImprimirArray(array);
            //Console.WriteLine("Array Ordenado BubbleSort");
            // op.BubbleSort(ref array);
            //op.Ordenar(ref array); // ordenado pelo método SORT da classe ARRAY;
            //op.ImprimirArray(array);

            // Console.WriteLine("Array antes da copia");
            // op.ImprimirArray(array);
            // op.Copiar(ref array, ref arrayCopia);
            // Console.WriteLine("Array após a copia");
            // op.ImprimirArray(arrayCopia);

            int valorProcurado = 3;
            // if (op.Existe(array, valorProcurado))
            // {
            //     Console.WriteLine("Encontrei o valor " + valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrei o valor " + valorProcurado);
            // }


            // int valorAchado = op.ObterValor(array, valorProcurado);
            // if (valorAchado > 0)
            //     Console.WriteLine("Encontrei o valor");
            // else
            //     Console.WriteLine("Não encontrei o valor");

            // int indeOf = op.ObterIndice(array, valorProcurado);

            // if (indeOf > -1)
            //     Console.WriteLine("O indice do elemento {0} é: {1} ", valorProcurado, indeOf);
            // else
            //     Console.WriteLine("Indice não encontrado");

            // Console.WriteLine($"Capacidade atual do array: {array.Length}");
            // op.RedimensionarArray(ref array, array.Length * 2);
            // Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");



            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            // if (TodosMaiorQue)
            //     Console.WriteLine("Todos os valores são maiores que: " + valorProcurado);
            // else
            //     Console.WriteLine("Existe valores que não são maiores que: " + valorProcurado);



            // int[] arrayInteiros = new int[3];
            // //Começa em 0 e vai até (n -1);
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");

            // Console.WriteLine("Percorrendo array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     Console.WriteLine(arrayInteiros[i]);
            // }
            // Console.WriteLine("Percorrendo array pelo ForEach");
            // foreach (var item in arrayInteiros)
            // {
            //     Console.WriteLine(item);
            // }


            //Array multidimensional
            // int[,] matriz = new int[4, 2]
            // {
            //     {8, 8},
            //     {10, 20},
            //     {50, 100},
            //     {90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++) // Linha
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++) //Coluna
            //     {
            //         Console.WriteLine(matriz[i, j]);
            //     }
            // }


        }
    }
}