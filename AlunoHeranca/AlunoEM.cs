using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoHeranca
{
    class AlunoEM : AlunoBase
    {
        public double N2 { get; set; }
        public double N3 { get; set; }

        public string Responsavel { get; set; }

        public override double CalcularMedia()
        {
            return (N1 + N2 + N3) / 3;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("N2: " + N2.ToString("0.0"));
            sb.AppendLine("N3: " + N3.ToString("0.0"));
            sb.AppendLine("Responsável: " + Responsavel);

            return base.ToString() + sb.ToString();
        }

    }
}
