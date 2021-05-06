using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoHeranca
{
    class AlunoPos : AlunoBase
    {
        public string InstituicaoEnsinoSuperior { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Graduado em: " + InstituicaoEnsinoSuperior;
        }
    }
}
