using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
                        string AsMedia(string[] nome, double[] a, double[] b, double[] c, double[] d) {
                var x = "";
                for (var i = 0; i < 10; i++)
                {
                    x += ("A média de " + nome[i] + " é " + (a[i] + b[i] + c[i] + d[i]) + "\n");
                }
                return x;
            }

            string[] nome = new string[10];
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];
            double[] nota3 = new double[10];
            double[] nota4 = new double[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome do aluno");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a primeira nota do aluno");
                nota1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do aluno");
                nota2[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota do aluno");
                nota3[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota do aluno");
                nota4[i] = double.Parse(Console.ReadLine());
            }

            Console.Write(AsMedia(nome, nota1, nota2, nota3, nota4));

            int aprovados = 0;
            double media;
            double media10 = 0;
            for (var i = 0; i < 10; i++)
            {
                media = (nota1[i] + nota2[i] + nota3[i] + nota4[i])/4;
                media10 = media10 + media;
                if (media >=7) {
                    aprovados ++;
                }
            }
            int reprovados = 10 - aprovados;
            media10 = media10 / 10;
            Console.Write("\n\nAprovados: " + aprovados + "\nReprovados: " + reprovados + "\nMédia geral: " + media10);
        }
    }
}
