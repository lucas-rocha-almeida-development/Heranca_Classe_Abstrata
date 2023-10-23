using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Classe_Abstrata
{   //classe filho
    internal class Funcionario : Pessoa
    {
        //Criando Atributo
        private UInt32 salario;
        //propriedade para manipulação
        public UInt32 Salario
        {
            get { return salario; } set { salario = value; }
        }
        //METODO PARA IMPRIMIR O SALARIO 
        public void MostraSalario()
        {
            Console.WriteLine("O salário do funcionário " + Nome + " é: " + Salario);
        }
        public Funcionario(string pNome,UInt32 pSalario) : base(pNome)
        {
            salario = pSalario;
        }
    }
}
