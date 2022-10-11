using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace VectorDominante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de elementos: ");
            int elementos = int.Parse(Console.ReadLine());
            int[] arreglo = (int[])Console.ReadLine().Split().Select(int.Parse).ToArray();                           
            Console.WriteLine("");
            int[] arreglo2 = (int[])Console.ReadLine().Split().Select(int.Parse).ToArray();
            int contador =0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > arreglo2[i]) { contador++; }                
                else if (arreglo[i] <= arreglo2[i])
                {
                    Console.WriteLine("0");
                    break;
                }
               
            }
            if (contador == arreglo.Length) { Console.WriteLine("1"); }                              
            Console.ReadKey();
        }
    }
}
