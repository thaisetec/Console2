using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a nota do aluno:");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a frequencia do aluno")
                int f = int.Parse(Console.ReadLine());
            if (nota >=7 || f >= 75)
            {
                Console.WriteLine()
            }

        }
    }
}
