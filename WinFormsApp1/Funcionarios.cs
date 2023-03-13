using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Funcionarios
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public double DTrabalhados { get; set; }
        public double VDiaria { get; set; }
        public double SBase { get; set; }
        public double ValorIR { get; set; }
        public double SLiquido { get; set; }

        public Funcionarios() {
            CPF = "";
            Nome = "";
        }
        public void SalarioBase()
        {
            SBase = DTrabalhados * VDiaria;
        }
        public void ValordeIR()
        {
            if(SBase < 1903.98){ValorIR = SBase * 0;}
            else if(SBase < 2826.65){ValorIR = SBase * 0.075;}
            else if(SBase < 3751.05){ValorIR = SBase * 0.15;}
            else if(SBase < 4664.68 || SBase > 4664.67){ValorIR = SBase * 0.225;}
        }
        public void SalarioLiquido()
        {
            SLiquido = SBase - ValorIR;
        }
    }
}
