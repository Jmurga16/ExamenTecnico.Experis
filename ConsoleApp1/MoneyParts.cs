using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MoneyParts
    {
        public List<List<Decimal>> build(Decimal monto)
        {
            var denominacion = new Decimal[] { 0.05M, 0.1M, 0.2M, 0.5M, 1, 2, 5, 10, 20, 50, 100, 200 };
            var result = new List<List<Decimal>>();
            

            foreach (var item in denominacion)
            {
                var lista = new List<Decimal>();
                if (monto >= item)
                {
                    if (monto % item == 0)
                    {
                        var ciclo = monto / item;
                        for (int i = 0; i < ciclo; i++)
                        {
                            lista.Add(item);
                        }
                    }
                    result.Add(lista);
                }

                if (lista.Count > 0)
                {
                    Console.Write("[");

                    foreach (Object obj in lista)
                    {                       
                        Console.Write("{0}" + ";", obj);
                    }

                    Console.Write("]");
                    Console.WriteLine("");
                }
                
            }

            return result;
        }

    }
}
