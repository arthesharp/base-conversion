using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacao = 0, deci = 0, resto = 0;
            string sair = "", resultado = "", restohexa = "", resultadohexa = "";

            while (sair != "S")
            {
                Console.WriteLine("Qual operação você deseja fazer de conversão? \n 1 - para binario \n 2 - para octagonal \n 3 - para hexadecimal");
                operacao = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite o numero em decimal que você queira converter");
                deci = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (operacao)
                {
                    case 1:
                        while (deci > 0)
                        {
                            resto = deci % 2;
                            deci = deci / 2;
                            resultado = resto + resultado;
                        }
                        Console.WriteLine("O valor em decimal convertido para binario é: " + resultado + "(2)");
                        break;
                    case 2:
                        while (deci > 0)
                        {
                            resto = deci % 8;
                            deci = deci / 8;
                            resultado = resto + resultado;
                        }
                        Console.WriteLine("O valor em decimal convertido para octal é: " + resultado + "(8)");
                        break;

                    case 3:
                        while (deci > 0)
                        {
                            restohexa = Convert.ToString(deci % 16);
                            if ((deci % 16) == 10)
                            { restohexa = "A"; }
                            if ((deci % 16) == 11)
                            { restohexa = "B"; }
                            if ((deci % 16) == 12)
                            { restohexa = "C"; }
                            if ((deci % 16) == 13)
                            { restohexa = "D"; }
                            if ((deci % 16) == 14)
                            { restohexa = "E"; }
                            if ((deci % 16) == 15)
                            { restohexa = "F"; }
                            resultadohexa = restohexa + resultadohexa;
                            deci = deci / 16;
                        }
                        Console.WriteLine("O valor em decimal convertido para hexadecimal é: " + resultadohexa + "(16)");
                        break;
                    default:
                        Console.WriteLine("Value dosnt exist");
                        break;
                }
                Console.WriteLine("Para sair digite S maiusculosssssssssssss");
                sair = Console.ReadLine();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
    }
}
