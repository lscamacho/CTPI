using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda
    {
        public Int64 IdVenda { get; set; }

        public String Data { get; set; }

        public String Valor { get; set; }

        public Int64 MatriculaFuncionario { get; set; }

        public Int64 CpfCliente { get; set; }

        public Int64 IdProduto { get; set; }


    }
}
