using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkDesafioUmm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Professor Danilo. Aqui iremos te ajudar!");
            Console.WriteLine("Digite o nome do seu primeiro aluno");
            string primeiroAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Agora digite as notas uma abaixo da outra");
            double primeiroNotaUm = Convert.ToDouble(Console.ReadLine());
            double segundaNotaUm = Convert.ToDouble(Console.ReadLine());
            double terceiraNotaUm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu segundo aluno");
            string segundoAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Agora digite as notas uma abaixo da outra");
            double primeiroNotaDois = Convert.ToDouble(Console.ReadLine());
            double segundaNotaDois = Convert.ToDouble(Console.ReadLine());
            double terceiraNotaDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu terceiro aluno");
            string terceiroAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Agora digite as notas uma abaixo da outra");
            double primeiroNotaTres = Convert.ToDouble(Console.ReadLine());
            double segundaNotaTres = Convert.ToDouble(Console.ReadLine());
            double terceiraNotaTres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu quarto aluno");
            string quartoAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Agora digite as notas uma abaixo da outra");
            double primeiroNotaQuatro = Convert.ToDouble(Console.ReadLine());
            double segundaNotaQuatro = Convert.ToDouble(Console.ReadLine());
            double terceiraNotaQuatro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vamos aos resultados, Professor Danilo!" + "\n" + "A média das notas de " + primeiroAluno + " é " + ((primeiroNotaUm + segundaNotaUm + terceiraNotaUm) / 3) + "\n" + "A média das notas de " + segundoAluno + " é " + ((primeiroNotaDois + segundaNotaDois + terceiraNotaDois) / 3) +"\n" + "A média das notas de " + terceiroAluno + " é " + ((primeiroNotaTres + segundaNotaTres + terceiraNotaTres) / 3) +"\n"+ "E a média das notas de " + quartoAluno + " é " + ((primeiroNotaQuatro + segundaNotaQuatro + terceiraNotaQuatro) / 3));
            Console.ReadKey();
        }
    }
}
