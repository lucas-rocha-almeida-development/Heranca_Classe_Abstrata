using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Classe_Abstrata
{//classe MAE/PAI

    //Modificador abstract
    //A classe com modificador abstratic so podera ser HERDADA , não poderemos criar instancia objetos da classe
    internal abstract class Pessoa
    {
        public string nome;//atributo

        //Propriedade para alterar o atributo nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        //METODO PARA EXEMPLO
        public void MostrarNome()
        {

            Console.WriteLine("O nome da pessoa é: " + nome);
        }
        //CONSTRUTOR

        public Pessoa (string pNome)
        {

            this.nome = pNome;
        }

    }
}
