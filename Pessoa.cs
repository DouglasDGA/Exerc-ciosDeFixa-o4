using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosDeFixação4
{
    class Pessoa
    {
        private string funcionario;
        private string sexo;
        private string salario;
        private string media;
        public string Funcionario
        {
            get { return funcionario; }
        }

        public string Sobrenome
        {
            get { return sexo; }
        }

        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Media
        {
            get { return media; }
            set { media = value; }
        }

        public Pessoa(string funcionario, string sexo, string salario, string media)
        {
            this.funcionario = funcionario;
            this.sexo = sexo;
            this.salario = salario;
            this.media = media;
        }
    }
}
