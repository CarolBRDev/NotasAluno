using System;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos).

            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite a nota do primeiro trimestre (0 a 100 pontos): ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo trimestre (0 a 100 pontos): ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro trimestre (0 a 100 pontos): ");
            int nota3 = int.Parse(Console.ReadLine());

            int peso1 = 30;
            int peso2 = 35;
            int peso3 = 35;

            int notaFinal = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            
            if (notaFinal >= 60)
            {
                Console.WriteLine($" A nota final do(a) aluno(a) {nomeAluno} é: {notaFinal}. O(A) aluno(a) foi APROVADO(A)!"); ;
            }
            else
            {
                int pontosFaltantes = 60 - notaFinal;
                Console.WriteLine($" A nota final do(a) aluno(a) {nomeAluno} é: {notaFinal}. O(A) aluno(a) foi REPROVADO(A). Pontos faltantes para alcançar a média mínima para aprovação: {pontosFaltantes} ");
               
            }

          
        }
    }
}
