using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_multidimensionales
{
    using System;

    class Program
    {
        static void Main()
        {
            // Definimos una matriz multidimensional (en este caso, una matriz 3x3).
            int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            // Obtenemos las dimensiones de la matriz.
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Recorremos la matriz utilizando dos bucles for anidados.
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.WriteLine($"matriz[{fila},{columna}] = {matriz[fila, columna]}");
                }
            }

            Console.ReadLine();
        }
    }