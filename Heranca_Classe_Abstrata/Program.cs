using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Classe_Abstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {   // classe abstrata não pode ser instanciada 
            // Pessoa pessoa = new Pessoa("Lucas");
            Funcionario meuFuncionario = new Funcionario(" Lucas Almeida ", 2300);

            meuFuncionario.MostrarNome();
            meuFuncionario.MostraSalario();
            Console.ReadKey();
        }
    }
}
