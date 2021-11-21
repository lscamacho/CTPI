using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pagamento
    {
        public Int64 IdPagamento { get; set; }

        public String TipoPagamento { get; set; }

        public Int64 IdVenda { get; set; }


    }
}
