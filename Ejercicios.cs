using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen__R
{
    internal class Ejercicios
    {

        public void Calificaciones()
        {
            Random ran = new Random();
            int ordenar;
            int mover;
            int cali = ran.Next(100);
            int[] calif = new int[cali];

            for (int i = 0; i > calif.Length; i++)
            {
                
            }


        }

        public void Vendedor()
        {
            int[,] vendedor = new int[5, 4] { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300, }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };
            for (int filas = 0; filas < 1; filas++)

            {
                int producto1 = 500 + 3000 + 100 + 400;
                int producto2 = 1000 + 150 + 200 + 500;
                int producto3 = 250 + 1800 + 2900 + 300;
                int producto4 = 400 + 130 + 90 + 2400;
                int producto5 = 60 + 20 + 4000 + 3600;
                Console.WriteLine($"El producto 1 genero {producto1} pesos de ganancia :");
                Console.WriteLine($"El producto 2 genero {producto2} pesos de ganancia :");
                Console.WriteLine($"El producto 3 genero {producto3} pesos de ganancia :");
                Console.WriteLine($"El producto 4 genero {producto4} pesos de ganancia :");
                Console.WriteLine($"El producto 5 genero {producto5} pesos de ganancia :");
            }

            Console.WriteLine();

            for (int columnas = 0; columnas < 1; columnas++)
            {
                int vendedor1 = 500 + 1000 + 250 + 400 + 60;
                int vendedor2 = 3000 + 150 + 1800 + 130 + 20;
                int vendedor3 = 100 + 200 + 2900 + 300;
                int vendedor4 = 400 + 500 + 300 + 2400 + 3600;
                Console.WriteLine($"La ganancia del vendedor 1 es {vendedor1} ");
                Console.WriteLine($"La ganancia del vendedor 2 es {vendedor2} ");
                Console.WriteLine($"La ganancia del vendedor 3 es {vendedor3} ");
                Console.WriteLine($"La ganancia del vendedor 4 es {vendedor4} ");

            }
        }

    }