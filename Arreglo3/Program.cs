using System;

namespace Arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Hello World Cod-ex!");
            int contador = 0;
            int sumatoria = 0;
            
            int[] numeros = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            
            foreach (int numero in numeros)
            {
                
                contador = contador + 1;
                sumatoria = sumatoria + numero;
                Console.WriteLine(numero);

            }
            Console.WriteLine("Cantidad de elementos son = "+contador);
            Console.WriteLine("La suma de los 10 elementos es = "+sumatoria);


        }
    }
}
