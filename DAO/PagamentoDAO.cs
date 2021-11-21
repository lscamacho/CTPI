using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PagamentoDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a dados

        public Dictionary<Int64, Pagamento> BuscarTodos()
        {
            Dictionary<Int64, Pagamento> mapaPagamento = new Dictionary<Int64, Pagamento>();

            try
            {
                String SQL = "SELECT  " +
                    "[id_pagamento]," +
                    "[tipo_pagamento]," +
                    "[id_venda]," +                    
                    "FROM [pagamento] ORDER BY id_pagamento;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pagamento p = new Pagamento();

                    p.IdPagamento = data.GetInt64(0);
                    p.TipoPagamento = data.GetString(1);
                    p.IdVenda = data.GetInt64(2);
                 


                    mapaPagamento.Add(p.IdPagamento, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaPagamento;
        }

        public Dictionary<Int64, Pagamento> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Pagamento> mapaPagamento = new Dictionary<Int64, Pagamento>();
            try
            {
                String SQL = "SELECT * FROM pagamento WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("id_pagamento = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("tipo_pagamento LIKE '%{0}%'", _filtro);
                }

                SQL += " ORDER BY id_pagamento;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pagamento p = new Pagamento();

                    p.IdPagamento = data.GetInt64(0);
                    p.TipoPagamento = data.GetString(1);
                    p.IdVenda = data.GetInt64(2);



                    mapaPagamento.Add(p.IdPagamento, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELOS FILTROS / " + ex.Message);
            }

            return mapaPagamento;
        }

        public Pagamento BuscarPorIdPagamento(Int64 _idPagamento)
        {
            Pagamento p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pagamento WHERE id_pagamento = {0};", _idPagamento);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Pagamento();


                    p.IdPagamento = data.GetInt64(0);
                    p.TipoPagamento = data.GetString(1);
                    p.IdVenda = data.GetInt64(2);


                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO ID / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Pagamento _obj)
        {
            int linhasAfetasdas = 0;

            try
            {


                String SQL = String.Format("INSERT INTO Pagamento (" +
                    "id_pagamento," +
                    "tipo_pagamento," +
                    "id_venda," +                    
                    ") " +
                    "VALUES ({0}, '{1}', '{2}');",
                    _obj.IdPagamento,
                    _obj.TipoPagamento,
                    _obj.IdVenda
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Deletar(Int64 _idPagamento)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM pagamento WHERE id_pagamento = " + _idPagamento;

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Alterar(Pagamento _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE pagamento SET " +                    
                    "tipo_pagamento," +
                    "id_venda," +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}');",                    
                    _obj.TipoPagamento,
                    _obj.IdVenda,
                    _obj.IdPagamento
                    );


                {
                    linhasAfetasdas = BD.ExecutarIDU(SQL);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
