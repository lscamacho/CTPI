using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Cliente
    {
        public Int64 Cpf { get; set; }

        public String Nome { get; set; }

        public String Logradouro { get; set; }

        public DateTime DataNascimento { get; set; }

        public String Sexo { get; set; }

        public String EstadoCivil { get; set; }

        public String Telefone { get; set; }

        public String Cep { get; set; }

        public float RendaMensal { get; set; }

        public String Estado { get; set; }

        public String Cidade { get; set; }

    }
}
