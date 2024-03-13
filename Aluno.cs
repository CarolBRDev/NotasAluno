using System;
using System.Collections.Generic;
using System.Text;

namespace NotasAluno
{
    public class Aluno
    {
        public string nomeAluno;
        public int nota1;
        public int nota2;
        public int nota3;
        public int peso1 = 30;
        public int peso2 = 35;
        public int peso3 = 35;
        public int notaFinal;
        public int pontosFaltantes;

        public int CalculaNotaFinal()
        {
            notaFinal = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            return notaFinal;
        }

        public int CalculaPontosFaltantes()
        {
            pontosFaltantes = 60 - notaFinal;
            return pontosFaltantes;
        }
    }
}
