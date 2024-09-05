
namespace MediaTrimestralPonderada
{
    class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Nota1
        {
            get { return _nota1; }
            set { _nota1 = value; }
        }

        public double Nota2
        {
            get { return _nota2; }
            set { _nota2 = value; }
        }

        public double Nota3
        {
            get { return _nota3; }
            set { _nota3 = value; }
        }


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
    }
}