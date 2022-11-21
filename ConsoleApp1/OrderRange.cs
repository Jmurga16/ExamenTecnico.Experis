using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderRange
    {
       public string build()
        {
            var response="";
            var pares = "";
            var impares = "";

            Console.WriteLine("Digite la cantidad de numeros a ordenar");
            int cantidad = int.Parse(Console.ReadLine());

            int[] array = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                array[i] = numero;
            }
            Array.Sort(array);

            foreach (int value in array)
            {
                //Si es numero Par
                if ((value % 2) == 0)
                {
                    pares += value+ ",";
                }
                else
                {
                    impares += value + ",";
                }
            }
            pares = pares.TrimEnd(',');
            impares = impares.TrimEnd(',');
            
            response = "["+pares+"][" + impares+"]";

            return response;
        }

    }
}
