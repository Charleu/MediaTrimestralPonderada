using System;

namespace MediaTrimestralPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            string separador = new string('-', 50);

            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a nota do primeiro semestre:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota do segundo semestre:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota do terceiro semestre:");
            double nota3 = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);
            double notaFinal = aluno.CalculaNotaFinal();

            Console.WriteLine(separador);
            Console.WriteLine($"Nota final de {aluno.Nome}: {notaFinal.ToString("F2")}");

            if (notaFinal >= 60)
            {
                Console.WriteLine("Status: Aluno aprovado!");
            }
            else
            {
                double pontosFaltantes = 60 - notaFinal;
                Console.WriteLine($"Status: Aluno reprovado! Pontos restantes para ser aprovado: {pontosFaltantes.ToString("F2")}");
            }
            Console.WriteLine(separador);
        }
    }

}
