using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extenso;

namespace ConsoleApplicationExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("numero: ");
                string numero = Console.ReadLine();
                if(string.IsNullOrEmpty(numero))
                {
                    break;
                }
                var porExtenso = NumeroExtenso.Converter(numero);
                Console.WriteLine(porExtenso);
            }
        }
    }
}
