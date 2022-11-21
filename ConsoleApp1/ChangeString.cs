using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChangeString
    {
        public static string build(string text)
        {

            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {

                if (Char.IsLetter(chars[i]))
                {

                    switch (chars[i])
                    {
                        case 'z':
                            chars[i] = char.Parse("a");
                            break;
                        case 'Z':
                            chars[i] = char.Parse("A");
                            break;
                        case 'ñ':
                            chars[i] = char.Parse("o");
                            break;
                        case 'Ñ':
                            chars[i] = char.Parse("O");
                            break;
                        default:
                            chars[i] += (char)1;
                            break;
                    }

                }
                else
                {
                    chars[i] += (char)0;
                }

            }

            string result = new string(chars);

            Console.WriteLine(result);
            return result;
        }


    }
}
