using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[] vet = Console.ReadLine().Split(' ');
                int codigo = int.Parse(vet[0]);
                int qte = int.Parse(vet[1]);

                double total;
                
                if (codigo == 1)
                {
                    total = qte * 4.0;
                }
                else if (codigo == 2)
                {
                    total = qte * 4.5;
                }
                else if (codigo == 2)
                {
                    total = qte * 4.5;
                }
                else if (codigo == 3)
                {
                    total = qte * 5.0;
                }
                else if (codigo == 4)
                {
                    total = qte * 2.0;
                }
                else
                {
                    total = qte * 1.5;
                }

                Console.WriteLine("Total: R$ " + total.ToString("F2", CI));
            }
        }
    }
}