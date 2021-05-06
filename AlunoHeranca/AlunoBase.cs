using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoHeranca
{
    class AlunoBase : Object
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public double N1 { get; set; }
        public int Faltas { get; set; }

        public Aprovacao situacao { get; set; }

        public virtual double CalcularMedia() // virtual significa que um método *pode* ser modificado nas classes descendentes
        {
            return N1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RA: " + RA);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("N1: " + N1.ToString("0.0"));
            sb.AppendLine("Média: " + CalcularMedia().ToString("0.0"));
            sb.AppendLine("Frequencia do Aluno: %" + FrequenciaAluno().ToString("0.0"));
            sb.AppendLine("Situação :" + situacao);

            return sb.ToString();
        }
        public double FrequenciaAluno()
        {
            return ((double)(80-Faltas)/80) * 100;
        }

        public void Avaliacao(int corte)
        {
            if (CalcularMedia() >= corte && FrequenciaAluno() >= 75)
                situacao = Aprovacao.Aprovado;
            else
                situacao = Aprovacao.Reprovado;
           
        }

        
    }
}
