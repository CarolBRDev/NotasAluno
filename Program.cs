using System;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            
            Console.WriteLine("Digite o nome do aluno: ");
            x.nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite a nota do primeiro trimestre (0 a 100 pontos): ");
            x.nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo trimestre (0 a 100 pontos): ");
            x.nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro trimestre (0 a 100 pontos): ");
            x.nota3 = int.Parse(Console.ReadLine());

            int notaFinalX = x.CalculaNotaFinal();
                        
            if (notaFinalX >= 60)
            {
                Console.WriteLine($" A nota final do(a) aluno(a) {x.nomeAluno} é: {notaFinalX}. O(A) aluno(a) foi APROVADO(A)!"); ;
            }
            else
            {
                int pontosFaltantes = x.CalculaPontosFaltantes();

                Console.WriteLine($" A nota final do(a) aluno(a) {x.nomeAluno} é: {notaFinalX}. O(A) aluno(a) foi REPROVADO(A). Pontos faltantes para alcançar a média mínima para aprovação: {pontosFaltantes} ");
               
            }

          
        }
    }
}
