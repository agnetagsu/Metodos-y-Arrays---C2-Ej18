using System;

namespace Metodos_y_Arrays___C2_Ej18
{
    class ArraysAleatorios
    {
        public void Rellenarvalores(int[] argarray, int min, int max)
        {
            ArraysAleatorios aleato = new ArraysAleatorios();
            for (int i = 0; i < argarray.Length; i++)
            {
                argarray[i] = aleato.aleatorio(min,max);
            }
        }
        public void MostrarvaloresySuma(int[] argarray)
        {
            int suma = 0;
            for (int i = 0; i < argarray.Length; i++)
            {
                Console.WriteLine(argarray[i]);
                suma = suma + argarray[i];
            }
            Console.WriteLine("La suma es: {0}",suma);
        }

        private int aleatorio(int min, int max)
        {
            Random numeroaleatorio = new Random();
            return numeroaleatorio.Next(min, max);
        }
        static void Main(string[] args)
        {
            int[] nuevoarray;
            int max, min;
            int longitud;
            ArraysAleatorios miarray = new ArraysAleatorios();
            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());

            nuevoarray = new int[longitud];

            Console.WriteLine("Introduce el valor mínimo:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor máximo:");
            max = Convert.ToInt32(Console.ReadLine());

            miarray.Rellenarvalores(nuevoarray,min,max);
            miarray.MostrarvaloresySuma(nuevoarray);

        }
    }
}
