using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Cliente
    {
        private Int32 Cpf { get; set; }

        public String Nome { get; set; }

        public String Longradouro { get; set; }

        public DateTime DataNascimento { get; set; }

        public String Sexo { get; set; }

        public String EstadoCivil { get; set; }

        public String Telefone { get; set; }

        public String Cep { get; set; }


    }
}
