using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[5] { 1, 3, 7, 12, 8 };
            int[] array2 = { 1, 3, 2, 7, 6, 12 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array1[i]);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(array2[j]);
                j++;
            }

            foreach (int x in array1)
            {
                Console.WriteLine(x);
            }

            //Tipos primitivos
            char Letra = 'A';
            int Total = 0;
            double Pi = 3.14;
            Console.WriteLine("Char: {0}; Int: {1}; Double: {2}", Letra, Total, Pi);
            Console.WriteLine("Hello World!");


            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine(array2D[0, 1]);


            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };



            //instanciando um objeto
            var objCliente = new Cliente("Fausto", "Jorge");
            var objVip = new Vip("Fausto", "Jorge");

            Console.WriteLine("Cliente Normal {0}", objCliente.ObterValorCheque());
            Console.WriteLine("Cliente Vip {0}", objVip.ObterValorCheque());
            Console.WriteLine(objVip.ObterValorCheque(2));
        }
    }
}