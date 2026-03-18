using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Atividade_Comp_Prof_Arthur
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double[] Notas { get; set; } = new double[3];

        public double somaNotas { get; set; }
        public double mediaNotas { get; set; }






        public override string ToString() =>$"O aluno {Nome.ToUpper()} tem {Idade} anos e a média das notas é {mediaNotas:F2}";
        
    }


}
