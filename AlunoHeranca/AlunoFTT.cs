using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoHeranca
{
    class AlunoFTT : AlunoBase
    {
        public double N2 { get; set; }
        public int HorasEstagio { get; set; }

        public override double CalcularMedia()
        {
            return N1 * 0.4 + N2 * 0.6;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("N2: " + N2.ToString("0.0"));
            sb.AppendLine("Horas de estágio: " + HorasEstagio);
            return base.ToString() + sb.ToString();
        }
    }
}
