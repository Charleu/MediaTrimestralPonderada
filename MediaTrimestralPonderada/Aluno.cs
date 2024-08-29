
namespace MediaTrimestralPonderada
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalculaNotaFinal()
        {
            return (Nota1 * 30 + Nota2 * 35 + Nota3 * 35) / 100;
        }

        public void ExibirResultado()
        {
            string separador = new string('-', 50);
            double notaFinal = CalculaNotaFinal();
            string resultado;

            if (notaFinal >= 60)
            {
                resultado = "Aluno aprovado!";
            }
            else
            {
                double pontosFaltantes = 60 - notaFinal;
                resultado = $"Aluno reprovado!Pontos restantes para ser aprovado: {pontosFaltantes.ToString("F2")}";
            }

            Console.WriteLine(separador);
            Console.WriteLine($"Nota final de {Nome}: {notaFinal.ToString("F2")}");
            Console.WriteLine(separador);
            Console.WriteLine(resultado);
            Console.WriteLine(separador);
        }
    }
}