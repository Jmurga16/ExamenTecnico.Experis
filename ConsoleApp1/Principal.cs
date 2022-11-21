using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Principal
    {
        static void Main(string[] args)
        {
            string TextoPrincipal = "";
            string valor;

            Found:
            Opciones();

            valor = Console.ReadLine();

            switch (valor)
            {
                case "1":
                    Console.WriteLine("Digitar una cadena");
                    var cadena = Console.ReadLine();
                    ChangeString.build(cadena);
                        
                    break;
                case "2":
                    var orderRange = new OrderRange();
                    var result = orderRange.build();
                    Console.WriteLine(result);
                    
                    break;
                case "3":
                    var moneyParts = new MoneyParts();
                    Console.WriteLine("Digitar un monto");
                    decimal value = decimal.Parse(Console.ReadLine());
                    var response = moneyParts.build(value);
                    break;
                default:
                    Console.Clear();
                    goto Found;

                    break;
            }
                                  

        }

        static void Opciones()
        {
            Console.WriteLine("Seleccionar que programa Desea iniciar");
            Console.WriteLine("1: ChangeString.cs");
            Console.WriteLine("2: OrderRange.cs");
            Console.WriteLine("3: MoneyParts.cs");
            Console.WriteLine("");
        }
    }
}
