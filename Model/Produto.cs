using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        public Int64 IdProduto { get; set; }
        public String Descricao { get; set; }
        public String Tipo { get; set; }
        public float Preco { get; set; }

    }
}
